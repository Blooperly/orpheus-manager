// Todo:
// Look into resource sinks. Gacha style storage to recycle high-volume resources for high-rarity resources?

// +---------------------+
// | Game Initialization |
// +---------------------+

function ManagerInit() {
	// Page Initialization
	$("#lib_chasm_version").html(lib_chasm_version());

	// Timing Initialization
	//chasm_timing_add_task_to_scheduler(autoSave, 			30000, 	chasm_task_flag_disable_multitick);
	//chasm_timing_init(animation_tick);

	// Load Saved Sheet
	loadSave();

	// Event handlers
	$("#fileinput").on("change", importHandler);

	$('#attrPer').on('blur', refreshUi);
	$('#attrFoc').on('blur', refreshUi);
	$('#attrDex').on('blur', refreshUi);
	$('#attrVit').on('blur', refreshUi);
	$('#attrCha').on('blur', refreshUi);
	$('#attrWil').on('blur', refreshUi);

	$(".saveableText").on('blur', storeSave);
	$(".skill_checkbox").change(storeSave);
	$(".wound_checkbox").change(storeSave);
	$(".mot_checkbox").change(storeSave);

	// Loading finished, reveal the game
	refreshUi();
	$("#manager_box").css("display", "block")
}

// +----------------+
// | Task Callbacks |
// +----------------+

// +-----------------+
// | Button Handling |
// +-----------------+

function rollDice() {
	let r1 = Math.floor(Math.random() * 3) - 1;
	let r2 = Math.floor(Math.random() * 3) - 1;
	let r3 = Math.floor(Math.random() * 3) - 1;

	let rr = r1 + r2 + r3;
	let rrr = rr.toString();
	if (rr > 0) rrr = "+" + rrr;

	if (r1 == -1) {
		$("#roller_1").html("<i class = 'material-icons' style = 'font-size: 48px;'>sentiment_very_dissatisfied</i>");
	} else if (r1 == 0) {
		$("#roller_1").html("<i class = 'material-icons' style = 'font-size: 48px;'>sentiment_neutral</i>");
	} else {
		$("#roller_1").html("<i class = 'material-icons' style = 'font-size: 48px;'>sentiment_very_satisfied</i>");
	}

	if (r2 == -1) {
		$("#roller_2").html("<i class = 'material-icons' style = 'font-size: 48px;'>sentiment_very_dissatisfied</i>");
	} else if (r2 == 0) {
		$("#roller_2").html("<i class = 'material-icons' style = 'font-size: 48px;'>sentiment_neutral</i>");
	} else {
		$("#roller_2").html("<i class = 'material-icons' style = 'font-size: 48px;'>sentiment_very_satisfied</i>");
	}

	if (r3 == -1) {
		$("#roller_3").html("<i class = 'material-icons' style = 'font-size: 48px;'>sentiment_very_dissatisfied</i>");
	} else if (r3 == 0) {
		$("#roller_3").html("<i class = 'material-icons' style = 'font-size: 48px;'>sentiment_neutral</i>");
	} else {
		$("#roller_3").html("<i class = 'material-icons' style = 'font-size: 48px;'>sentiment_very_satisfied</i>");
	}
	
	$("#roller_result").html(rrr);
}

// +---------------+
// | UI Management |
// +---------------+

// Refresh UI
function refreshUi() {
	let per = parseNumerals($("#attrPer").html());
	let foc = parseNumerals($("#attrFoc").html());
	let dex = parseNumerals($("#attrDex").html());
	let vit = parseNumerals($("#attrVit").html());
	let cha = parseNumerals($("#attrCha").html());
	let wil = parseNumerals($("#attrWil").html());

	displayDerivedAttr(per, foc, dex, vit, cha, wil);
	displayDerivedStrain(per, foc, dex, vit, cha, wil);
	displayWoundBoxes(foc, vit, wil);
}

// Derived Attributes
function parseNumerals(string) {
	if (string == 'I' || string == 'i' || string == '1') {
		return 1;
	} else if (string == 'II' || string == 'ii' || string == '2') {
		return 2;
	} else if (string == 'III' || string == 'iii' || string == '3') {
		return 3;
	} else if (string == 'IV' || string == 'iv' || string == '4') {
		return 4;
	} else if (string == 'V' || string == 'v' || string == '5') {
		return 5;
	}
	return 0;
}

function displayDerivedAttr(per, foc, dex, vit, cha, wil) {
	if (dex && vit) {
		$("#derMelee").html(Math.floor(0.5 * (dex + vit)));
		$("#derParry").html(Math.floor(0.5 * (dex + vit)));
		$("#derSpeed").html(Math.floor(0.5 * (dex + vit)));
	} else {
		$("#derMelee").html("");
		$("#derParry").html("");
		$("#derSpeed").html("");
	}

	if (dex && per) {
		$("#derRanged").html(Math.floor(0.5 * (dex + per)));
		$("#derEvade").html(Math.floor(0.5 * (dex + per)));
	} else {
		$("#derRanged").html("");
		$("#derEvade").html("");
	}

	if (per && (wil || foc)) {
		$("#derUnnatural").html(Math.floor(0.5 * (per + Math.max(wil, foc))));
	} else {
		$("#derUnnatural").html("");
	}

	if (per && foc) {
		$("#derVigilance").html(Math.floor(0.5 * (per + foc)));
	} else {
		$("#derVigilance").html("");
	}

	if (cha && (wil || foc)) {
		$("#derWariness").html(Math.floor(0.5 * (cha + Math.max(wil, foc))));
	} else {
		$("#derWariness").html("");
	}

	if (foc) {
		if (foc >= 5) {
			$("#derAcuity").html("2");
			$("#derAcumen").html("2");
		} else if (foc >= 3) {6
			$("#derAcuity").html("1");
			$("#derAcumen").html("1");
		} else {
			$("#derAcuity").html("0");
			$("#derAcumen").html("0");
		}
	} else {
		$("#derAcuity").html("");
		$("#derAcumen").html("");
	}

	if (vit) {
		if (vit >= 5) {
			$("#derToughness").html("2");
		} else if (vit >= 3) {6
			$("#derToughness").html("1");
		} else {
			$("#derToughness").html("0");
		}
	} else {
		$("#derToughness").html("");
	}

	if (wil) {
		if (wil >= 5) {
			$("#derFoW").html("2");
		} else if (wil >= 3) {6
			$("#derFoW").html("1");
		} else {
			$("#derFoW").html("0");
		}
	} else {
		$("#derFoW").html("");
	}

	if ((foc && wil) || (wil && dex) || (dex && foc)) {
		$("#derInitiative").html(foc + wil + dex - Math.min(foc, wil, dex));
	} else {
		$("#derInitiative").html("");
	}
}

function displayDerivedStrain(per, foc, dex, vit, cha, wil) {
	let ment = per + (3 * foc);
	let phys = dex + (3 * vit);
	let spir = cha + (3 * wil);

	$("#strainMentalMax").html(ment.toString());
	$("#strainPhysicalMax").html(phys.toString());
	$("#strainSpiritualMax").html(spir.toString());
}

function displayWoundBoxes(foc, vit, wil) {
	if (foc >= 5) {
		$("#wClarityLight3").attr("disabled", false);
		$("#wClarityLight4").attr("disabled", false);
		
		$("#wClaritySevere3").attr("disabled", false);
		$("#wClaritySevere4").attr("disabled", false);
		
		$("#wClarityCritical2").attr("disabled", false);
	} else if (foc >= 4) {
		$("#wClarityLight3").attr("disabled", false);
		$("#wClarityLight4").attr("disabled", false);
		
		$("#wClaritySevere3").attr("disabled", false);
		$("#wClaritySevere4").attr("disabled", true);
		
		$("#wClarityCritical2").attr("disabled", false);
	} else if (foc >= 3) {
		$("#wClarityLight3").attr("disabled", false);
		$("#wClarityLight4").attr("disabled", true);
		
		$("#wClaritySevere3").attr("disabled", false);
		$("#wClaritySevere4").attr("disabled", true);
		
		$("#wClarityCritical2").attr("disabled", false);
	} else if (foc >= 2) {
		$("#wClarityLight3").attr("disabled", false);
		$("#wClarityLight4").attr("disabled", true);
		
		$("#wClaritySevere3").attr("disabled", false);
		$("#wClaritySevere4").attr("disabled", true);
		
		$("#wClarityCritical2").attr("disabled", true);
	} else if (foc >= 1) {
		$("#wClarityLight3").attr("disabled", false);
		$("#wClarityLight4").attr("disabled", true);
		
		$("#wClaritySevere3").attr("disabled", true);
		$("#wClaritySevere4").attr("disabled", true);
		
		$("#wClarityCritical2").attr("disabled", true);
	} else {
		$("#wClarityLight3").attr("disabled", true);
		$("#wClarityLight4").attr("disabled", true);
		
		$("#wClaritySevere3").attr("disabled", true);
		$("#wClaritySevere4").attr("disabled", true);
		
		$("#wClarityCritical2").attr("disabled", true);
	}
	
	if (vit >= 5) {
		$("#wHealthLight3").attr("disabled", false);
		$("#wHealthLight4").attr("disabled", false);
		
		$("#wHealthSevere3").attr("disabled", false);
		$("#wHealthSevere4").attr("disabled", false);
		
		$("#wHealthCritical2").attr("disabled", false);
	} else if (vit >= 4) {
		$("#wHealthLight3").attr("disabled", false);
		$("#wHealthLight4").attr("disabled", false);
		
		$("#wHealthSevere3").attr("disabled", false);
		$("#wHealthSevere4").attr("disabled", true);
		
		$("#wHealthCritical2").attr("disabled", false);
	} else if (vit >= 3) {
		$("#wHealthLight3").attr("disabled", false);
		$("#wHealthLight4").attr("disabled", true);
		
		$("#wHealthSevere3").attr("disabled", false);
		$("#wHealthSevere4").attr("disabled", true);
		
		$("#wHealthCritical2").attr("disabled", false);
	} else if (vit >= 2) {
		$("#wHealthLight3").attr("disabled", false);
		$("#wHealthLight4").attr("disabled", true);
		
		$("#wHealthSevere3").attr("disabled", false);
		$("#wHealthSevere4").attr("disabled", true);
		
		$("#wHealthCritical2").attr("disabled", true);
	} else if (vit >= 1) {
		$("#wHealthLight3").attr("disabled", false);
		$("#wHealthLight4").attr("disabled", true);
		
		$("#wHealthSevere3").attr("disabled", true);
		$("#wHealthSevere4").attr("disabled", true);
		
		$("#wHealthCritical2").attr("disabled", true);
	} else {
		$("#wHealthLight3").attr("disabled", true);
		$("#wHealthLight4").attr("disabled", true);
		
		$("#wHealthSevere3").attr("disabled", true);
		$("#wHealthSevere4").attr("disabled", true);
		
		$("#wHealthCritical2").attr("disabled", true);
	}
	
	if (wil >= 5) {
		$("#wStressLight3").attr("disabled", false);
		$("#wStressLight4").attr("disabled", false);
		
		$("#wStressSevere3").attr("disabled", false);
		$("#wStressSevere4").attr("disabled", false);
		
		$("#wStressCritical2").attr("disabled", false);
	} else if (wil >= 4) {
		$("#wStressLight3").attr("disabled", false);
		$("#wStressLight4").attr("disabled", false);
		
		$("#wStressSevere3").attr("disabled", false);
		$("#wStressSevere4").attr("disabled", true);
		
		$("#wStressCritical2").attr("disabled", false);
	} else if (wil >= 3) {
		$("#wStressLight3").attr("disabled", false);
		$("#wStressLight4").attr("disabled", true);
		
		$("#wStressSevere3").attr("disabled", false);
		$("#wStressSevere4").attr("disabled", true);
		
		$("#wStressCritical2").attr("disabled", false);
	} else if (wil >= 2) {
		$("#wStressLight3").attr("disabled", false);
		$("#wStressLight4").attr("disabled", true);
		
		$("#wStressSevere3").attr("disabled", false);
		$("#wStressSevere4").attr("disabled", true);
		
		$("#wStressCritical2").attr("disabled", true);
	} else if (wil >= 1) {
		$("#wStressLight3").attr("disabled", false);
		$("#wStressLight4").attr("disabled", true);
		
		$("#wStressSevere3").attr("disabled", true);
		$("#wStressSevere4").attr("disabled", true);
		
		$("#wStressCritical2").attr("disabled", true);
	} else {
		$("#wStressLight3").attr("disabled", true);
		$("#wStressLight4").attr("disabled", true);
		
		$("#wStressSevere3").attr("disabled", true);
		$("#wStressSevere4").attr("disabled", true);
		
		$("#wStressCritical2").attr("disabled", true);
	}
}

// Materialize UI
$(document).ready(function(){
	M.AutoInit();
});

// +-----------------+
// | File Management |
// +-----------------+

// Game Save data
class saveData {
	saveCount;

	attrPer;
	attrFoc;
	attrDex;
	attrVit;
	attrCha;
	attrWil;

	charName;
	charArchetype;
	charBackground;
	charMotivation;
	charMotivation2;
	charMotivation3;
	charFears;
	charGoal;

	motCheck1;
	motCheck2;
	motCheck3;
	motCheck4;

	charConditions;
	charAcclimations;
	charExperience;

	charEquipment;

	humanityCurrent;
	humanityMax;

	mementoMori;

	thresholdDanger;
	thresholdDespair;
	thresholdDisgust;

	charNotes;
	charAbilities;

	strainMentalCurrent;
	strainPhysicalCurrent;
	strainSpiritualCurrent;

	cSkill0;
	cSkill1;
	cSkill2;
	cSkill3;
	cSkill4;
	cSkill5;
	cSkill6;
	cSkill7;
	cSkill8;
	cSkill9;
	cSkill10;

	cSkill0_rank;
	cSkill1_rank;
	cSkill2_rank;
	cSkill3_rank;
	cSkill4_rank;
	cSkill5_rank;
	cSkill6_rank;
	cSkill7_rank;
	cSkill8_rank;
	cSkill9_rank;
	cSkill10_rank;

	cSkill0_1;
	cSkill0_2;
	cSkill0_3;
	cSkill0_4;
	cSkill0_5;
	cSkill0_6;

	cSkill1_1;
	cSkill1_2;
	cSkill1_3;
	cSkill1_4;
	cSkill1_5;
	cSkill1_6;

	cSkill2_1;
	cSkill2_2;
	cSkill2_3;
	cSkill2_4;
	cSkill2_5;
	cSkill2_6;

	cSkill3_1;
	cSkill3_2;
	cSkill3_3;
	cSkill3_4;
	cSkill3_5;
	cSkill3_6;

	cSkill4_1;
	cSkill4_2;
	cSkill4_3;
	cSkill4_4;
	cSkill4_5;
	cSkill4_6;

	cSkill5_1;
	cSkill5_2;
	cSkill5_3;
	cSkill5_4;
	cSkill5_5;
	cSkill5_6;

	cSkill6_1;
	cSkill6_2;
	cSkill6_3;
	cSkill6_4;
	cSkill6_5;
	cSkill6_6;

	cSkill7_1;
	cSkill7_2;
	cSkill7_3;
	cSkill7_4;
	cSkill7_5;
	cSkill7_6;

	cSkill8_1;
	cSkill8_2;
	cSkill8_3;
	cSkill8_4;
	cSkill8_5;
	cSkill8_6;

	cSkill9_1;
	cSkill9_2;
	cSkill9_3;
	cSkill9_4;
	cSkill9_5;
	cSkill9_6;

	cSkill10_1;
	cSkill10_2;
	cSkill10_3;
	cSkill10_4;
	cSkill10_5;
	cSkill10_6;

	nSkill0;
	nSkill1;
	nSkill2;
	nSkill3;
	nSkill4;
	nSkill5;
	nSkill6;
	nSkill7;
	nSkill8;
	nSkill9;
	nSkill10;
	nSkill11;
	nSkill12;
	nSkill13;
	nSkill14;
	nSkill15;
	nSkill16;
	nSkill17;
	nSkill18;

	nSkill0_rank;
	nSkill1_rank;
	nSkill2_rank;
	nSkill3_rank;
	nSkill4_rank;
	nSkill5_rank;
	nSkill6_rank;
	nSkill7_rank;
	nSkill8_rank;
	nSkill9_rank;
	nSkill10_rank;
	nSkill11_rank;
	nSkill12_rank;
	nSkill13_rank;
	nSkill14_rank;
	nSkill15_rank;
	nSkill16_rank;
	nSkill17_rank;
	nSkill18_rank;

	nSkill0_1;
	nSkill0_2;
	nSkill0_3;
	nSkill0_4;
	nSkill0_5;
	nSkill0_6;

	nSkill1_1;
	nSkill1_2;
	nSkill1_3;
	nSkill1_4;
	nSkill1_5;
	nSkill1_6;

	nSkill2_1;
	nSkill2_2;
	nSkill2_3;
	nSkill2_4;
	nSkill2_5;
	nSkill2_6;

	nSkill3_1;
	nSkill3_2;
	nSkill3_3;
	nSkill3_4;
	nSkill3_5;
	nSkill3_6;

	nSkill4_1;
	nSkill4_2;
	nSkill4_3;
	nSkill4_4;
	nSkill4_5;
	nSkill4_6;

	nSkill5_1;
	nSkill5_2;
	nSkill5_3;
	nSkill5_4;
	nSkill5_5;
	nSkill5_6;

	nSkill6_1;
	nSkill6_2;
	nSkill6_3;
	nSkill6_4;
	nSkill6_5;
	nSkill6_6;

	nSkill7_1;
	nSkill7_2;
	nSkill7_3;
	nSkill7_4;
	nSkill7_5;
	nSkill7_6;

	nSkill8_1;
	nSkill8_2;
	nSkill8_3;
	nSkill8_4;
	nSkill8_5;
	nSkill8_6;

	nSkill9_1;
	nSkill9_2;
	nSkill9_3;
	nSkill9_4;
	nSkill9_5;
	nSkill9_6;

	nSkill10_1;
	nSkill10_2;
	nSkill10_3;
	nSkill10_4;
	nSkill10_5;
	nSkill10_6;

	nSkill11_1;
	nSkill11_2;
	nSkill11_3;
	nSkill11_4;
	nSkill11_5;
	nSkill11_6;

	nSkill12_1;
	nSkill12_2;
	nSkill12_3;
	nSkill12_4;
	nSkill12_5;
	nSkill12_6;

	nSkill13_1;
	nSkill13_2;
	nSkill13_3;
	nSkill13_4;
	nSkill13_5;
	nSkill13_6;

	nSkill14_1;
	nSkill14_2;
	nSkill14_3;
	nSkill14_4;
	nSkill14_5;
	nSkill14_6;

	nSkill15_1;
	nSkill15_2;
	nSkill15_3;
	nSkill15_4;
	nSkill15_5;
	nSkill15_6;

	nSkill16_1;
	nSkill16_2;
	nSkill16_3;
	nSkill16_4;
	nSkill16_5;
	nSkill16_6;

	nSkill17_1;
	nSkill17_2;
	nSkill17_3;
	nSkill17_4;
	nSkill17_5;
	nSkill17_6;

	nSkill18_1;
	nSkill18_2;
	nSkill18_3;
	nSkill18_4;
	nSkill18_5;
	nSkill18_6;

	wClarityLight1;
	wClarityLight2;
	wClarityLight3;
	wClarityLight4;

	wClaritySevere1;
	wClaritySevere2;
	wClaritySevere3;
	wClaritySevere4;

	wClarityCritical1;
	wClarityCritical2;

	wHealthLight1;
	wHealthLight2;
	wHealthLight3;
	wHealthLight4;

	wHealthSevere1;
	wHealthSevere2;
	wHealthSevere3;
	wHealthSevere4;

	wHealthCritical1;
	wHealthCritical2;

	wStressLight1;
	wStressLight2;
	wStressLight3;
	wStressLight4;

	wStressSevere1;
	wStressSevere2;
	wStressSevere3;
	wStressSevere4;

	wStressCritical1;
	wStressCritical2;

	constructor() {
		this.saveCount = 0;

		this.attrPer = "";
		this.attrFoc = "";
		this.attrDex = "";
		this.attrVit = "";
		this.attrCha = "";
		this.attrWil = "";
		
		this.charName = "";
		this.charArchetype = "";
		this.charBackground = "";
		this.charMotivation = "";
		this.charMotivation2 = "";
		this.charMotivation3 = "";
		this.charFears = "";
		this.charGoal = "";

		this.motCheck1 = false;
		this.motCheck2 = false;
		this.motCheck3 = false;
		this.motCheck4 = false;

		this.charConditions = "";
		this.charAcclimations = "";
		this.charExperience = "";
		
		this.charEquipment = "";

		this.humanityCurrent = "";
		this.humanityMax = "";

		this.mementoMori = "";

		this.thresholdDanger = "";
		this.thresholdDespair = "";
		this.thresholdDisgust = "";

		this.charNotes = "";
		this.charAbilities = "";
		
		this.strainMentalCurrent = "";
		this.strainPhysicalCurrent = "";
		this.strainSpiritualCurrent = "";
		
		this.cSkill0 = "";
		this.cSkill1 = "";
		this.cSkill2 = "";
		this.cSkill3 = "";
		this.cSkill4 = "";
		this.cSkill5 = "";
		this.cSkill6 = "";
		this.cSkill7 = "";
		this.cSkill8 = "";
		this.cSkill9 = "";
		this.cSkill10 = "";
		
		this.cSkill0_rank = "";
		this.cSkill1_rank = "";
		this.cSkill2_rank = "";
		this.cSkill3_rank = "";
		this.cSkill4_rank = "";
		this.cSkill5_rank = "";
		this.cSkill6_rank = "";
		this.cSkill7_rank = "";
		this.cSkill8_rank = "";
		this.cSkill9_rank = "";
		this.cSkill10_rank = "";

		this.cSkill0_1 = false;
		this.cSkill0_2 = false;
		this.cSkill0_3 = false;
		this.cSkill0_4 = false;
		this.cSkill0_5 = false;
		this.cSkill0_6 = false;
	
		this.cSkill1_1 = false;
		this.cSkill1_2 = false;
		this.cSkill1_3 = false;
		this.cSkill1_4 = false;
		this.cSkill1_5 = false;
		this.cSkill1_6 = false;
	
		this.cSkill2_1 = false;
		this.cSkill2_2 = false;
		this.cSkill2_3 = false;
		this.cSkill2_4 = false;
		this.cSkill2_5 = false;
		this.cSkill2_6 = false;
	
		this.cSkill3_1 = false;
		this.cSkill3_2 = false;
		this.cSkill3_3 = false;
		this.cSkill3_4 = false;
		this.cSkill3_5 = false;
		this.cSkill3_6 = false;
	
		this.cSkill4_1 = false;
		this.cSkill4_2 = false;
		this.cSkill4_3 = false;
		this.cSkill4_4 = false;
		this.cSkill4_5 = false;
		this.cSkill4_6 = false;
	
		this.cSkill5_1 = false;
		this.cSkill5_2 = false;
		this.cSkill5_3 = false;
		this.cSkill5_4 = false;
		this.cSkill5_5 = false;
		this.cSkill5_6 = false;
	
		this.cSkill6_1 = false;
		this.cSkill6_2 = false;
		this.cSkill6_3 = false;
		this.cSkill6_4 = false;
		this.cSkill6_5 = false;
		this.cSkill6_6 = false;
	
		this.cSkill7_1 = false;
		this.cSkill7_2 = false;
		this.cSkill7_3 = false;
		this.cSkill7_4 = false;
		this.cSkill7_5 = false;
		this.cSkill7_6 = false;
	
		this.cSkill8_1 = false;
		this.cSkill8_2 = false;
		this.cSkill8_3 = false;
		this.cSkill8_4 = false;
		this.cSkill8_5 = false;
		this.cSkill8_6 = false;
	
		this.cSkill9_1 = false;
		this.cSkill9_2 = false;
		this.cSkill9_3 = false;
		this.cSkill9_4 = false;
		this.cSkill9_5 = false;
		this.cSkill9_6 = false;
	
		this.cSkill10_1 = false;
		this.cSkill10_2 = false;
		this.cSkill10_3 = false;
		this.cSkill10_4 = false;
		this.cSkill10_5 = false;
		this.cSkill10_6 = false;
		
		this.nSkill0 = "";
		this.nSkill1 = "";
		this.nSkill2 = "";
		this.nSkill3 = "";
		this.nSkill4 = "";
		this.nSkill5 = "";
		this.nSkill6 = "";
		this.nSkill7 = "";
		this.nSkill8 = "";
		this.nSkill9 = "";
		this.nSkill10 = "";
		this.nSkill11 = "";
		this.nSkill12 = "";
		this.nSkill13 = "";
		this.nSkill14 = "";
		this.nSkill15 = "";
		this.nSkill16 = "";
		this.nSkill17 = "";
		this.nSkill18 = "";
		
		this.nSkill0_rank = "";
		this.nSkill1_rank = "";
		this.nSkill2_rank = "";
		this.nSkill3_rank = "";
		this.nSkill4_rank = "";
		this.nSkill5_rank = "";
		this.nSkill6_rank = "";
		this.nSkill7_rank = "";
		this.nSkill8_rank = "";
		this.nSkill9_rank = "";
		this.nSkill10_rank = "";
		this.nSkill11_rank = "";
		this.nSkill12_rank = "";
		this.nSkill13_rank = "";
		this.nSkill14_rank = "";
		this.nSkill15_rank = "";
		this.nSkill16_rank = "";
		this.nSkill17_rank = "";
		this.nSkill18_rank = "";

		this.nSkill0_1 = false;
		this.nSkill0_2 = false;
		this.nSkill0_3 = false;
		this.nSkill0_4 = false;
		this.nSkill0_5 = false;
		this.nSkill0_6 = false;
	
		this.nSkill1_1 = false;
		this.nSkill1_2 = false;
		this.nSkill1_3 = false;
		this.nSkill1_4 = false;
		this.nSkill1_5 = false;
		this.nSkill1_6 = false;
	
		this.nSkill2_1 = false;
		this.nSkill2_2 = false;
		this.nSkill2_3 = false;
		this.nSkill2_4 = false;
		this.nSkill2_5 = false;
		this.nSkill2_6 = false;
	
		this.nSkill3_1 = false;
		this.nSkill3_2 = false;
		this.nSkill3_3 = false;
		this.nSkill3_4 = false;
		this.nSkill3_5 = false;
		this.nSkill3_6 = false;
	
		this.nSkill4_1 = false;
		this.nSkill4_2 = false;
		this.nSkill4_3 = false;
		this.nSkill4_4 = false;
		this.nSkill4_5 = false;
		this.nSkill4_6 = false;
	
		this.nSkill5_1 = false;
		this.nSkill5_2 = false;
		this.nSkill5_3 = false;
		this.nSkill5_4 = false;
		this.nSkill5_5 = false;
		this.nSkill5_6 = false;
	
		this.nSkill6_1 = false;
		this.nSkill6_2 = false;
		this.nSkill6_3 = false;
		this.nSkill6_4 = false;
		this.nSkill6_5 = false;
		this.nSkill6_6 = false;
	
		this.nSkill7_1 = false;
		this.nSkill7_2 = false;
		this.nSkill7_3 = false;
		this.nSkill7_4 = false;
		this.nSkill7_5 = false;
		this.nSkill7_6 = false;
	
		this.nSkill8_1 = false;
		this.nSkill8_2 = false;
		this.nSkill8_3 = false;
		this.nSkill8_4 = false;
		this.nSkill8_5 = false;
		this.nSkill8_6 = false;
	
		this.nSkill9_1 = false;
		this.nSkill9_2 = false;
		this.nSkill9_3 = false;
		this.nSkill9_4 = false;
		this.nSkill9_5 = false;
		this.nSkill9_6 = false;
	
		this.nSkill10_1 = false;
		this.nSkill10_2 = false;
		this.nSkill10_3 = false;
		this.nSkill10_4 = false;
		this.nSkill10_5 = false;
		this.nSkill10_6 = false;
	
		this.nSkill11_1 = false;
		this.nSkill11_2 = false;
		this.nSkill11_3 = false;
		this.nSkill11_4 = false;
		this.nSkill11_5 = false;
		this.nSkill11_6 = false;
	
		this.nSkill12_1 = false;
		this.nSkill12_2 = false;
		this.nSkill12_3 = false;
		this.nSkill12_4 = false;
		this.nSkill12_5 = false;
		this.nSkill12_6 = false;
	
		this.nSkill13_1 = false;
		this.nSkill13_2 = false;
		this.nSkill13_3 = false;
		this.nSkill13_4 = false;
		this.nSkill13_5 = false;
		this.nSkill13_6 = false;
	
		this.nSkill14_1 = false;
		this.nSkill14_2 = false;
		this.nSkill14_3 = false;
		this.nSkill14_4 = false;
		this.nSkill14_5 = false;
		this.nSkill14_6 = false;
	
		this.nSkill15_1 = false;
		this.nSkill15_2 = false;
		this.nSkill15_3 = false;
		this.nSkill15_4 = false;
		this.nSkill15_5 = false;
		this.nSkill15_6 = false;
	
		this.nSkill16_1 = false;
		this.nSkill16_2 = false;
		this.nSkill16_3 = false;
		this.nSkill16_4 = false;
		this.nSkill16_5 = false;
		this.nSkill16_6 = false;
	
		this.nSkill17_1 = false;
		this.nSkill17_2 = false;
		this.nSkill17_3 = false;
		this.nSkill17_4 = false;
		this.nSkill17_5 = false;
		this.nSkill17_6 = false;
	
		this.nSkill18_1 = false;
		this.nSkill18_2 = false;
		this.nSkill18_3 = false;
		this.nSkill18_4 = false;
		this.nSkill18_5 = false;
		this.nSkill18_6 = false;

		this.wClarityLight1;
		this.wClarityLight2;
		this.wClarityLight3;
		this.wClarityLight4;
	
		this.wClaritySevere1;
		this.wClaritySevere2;
		this.wClaritySevere3;
		this.wClaritySevere4;
	
		this.wClarityCritical1;
		this.wClarityCritical2;
	
		this.wHealthLight1;
		this.wHealthLight2;
		this.wHealthLight3;
		this.wHealthLight4;
	
		this.wHealthSevere1;
		this.wHealthSevere2;
		this.wHealthSevere3;
		this.wHealthSevere4;
	
		this.wHealthCritical1;
		this.wHealthCritical2;
	
		this.wStressLight1;
		this.wStressLight2;
		this.wStressLight3;
		this.wStressLight4;
	
		this.wStressSevere1;
		this.wStressSevere2;
		this.wStressSevere3;
		this.wStressSevere4;
	
		this.wStressCritical1;
		this.wStressCritical2;
	}
}

var chasm_save;
var chasm_incoming_save;
const save_path = "orpheus";

function loadSave() {
	loadSaveFromObject(lib_chasm_load_save(save_path));
	refreshUi();
}

function loadSaveFromObject(object) {
	if (object) {
		chasm_save = new saveData();

		// Merge Save
		lib_chasm_merge_save(chasm_save, object);

		// Load Game
		$("#attrPer").html(chasm_save.attrPer);
		$("#attrFoc").html(chasm_save.attrFoc);
		$("#attrDex").html(chasm_save.attrDex);
		$("#attrVit").html(chasm_save.attrVit);
		$("#attrCha").html(chasm_save.attrCha);
		$("#attrWil").html(chasm_save.attrWil);

		$("#charName").html(chasm_save.charName);
		$("#charArchetype").html(chasm_save.charArchetype);
		$("#charBackground").html(chasm_save.charBackground);
		$("#charMotivation").html(chasm_save.charMotivation);
		$("#charMotivation2").html(chasm_save.charMotivation2);
		$("#charMotivation3").html(chasm_save.charMotivation3);
		$("#charFears").html(chasm_save.charFears);
		$("#charGoal").html(chasm_save.charGoal);

		if (chasm_save.motCheck1) $("#motCheck1").prop('checked', true); else $("#motCheck1").prop('checked', false);
		if (chasm_save.motCheck2) $("#motCheck2").prop('checked', true); else $("#motCheck2").prop('checked', false);
		if (chasm_save.motCheck3) $("#motCheck3").prop('checked', true); else $("#motCheck3").prop('checked', false);
		if (chasm_save.motCheck4) $("#motCheck4").prop('checked', true); else $("#motCheck4").prop('checked', false);

		$("#charConditions").html(chasm_save.charConditions);
		$("#charAcclimations").html(chasm_save.charAcclimations);
		$("#charExperience").html(chasm_save.charExperience);

		$("#charEquipment").html(chasm_save.charEquipment);
		
		$("#humanityCurrent").html(chasm_save.humanityCurrent);
		$("#humanityMax").html(chasm_save.humanityMax);
		
		$("#mementoMori").html(chasm_save.mementoMori);

		$("#thresholdDanger").html(chasm_save.thresholdDanger);
		$("#thresholdDespair").html(chasm_save.thresholdDespair);
		$("#thresholdDisgust").html(chasm_save.thresholdDisgust);

		$("#charNotes").html(chasm_save.charNotes);
		$("#charAbilities").html(chasm_save.charAbilities);
		
		$("#strainMentalCurrent").html(chasm_save.strainMentalCurrent);
		$("#strainPhysicalCurrent").html(chasm_save.strainPhysicalCurrent);
		$("#strainSpiritualCurrent").html(chasm_save.strainSpiritualCurrent);
		
		$("#cSkill0").html(chasm_save.cSkill0);
		$("#cSkill1").html(chasm_save.cSkill1);
		$("#cSkill2").html(chasm_save.cSkill2);
		$("#cSkill3").html(chasm_save.cSkill3);
		$("#cSkill4").html(chasm_save.cSkill4);
		$("#cSkill5").html(chasm_save.cSkill5);
		$("#cSkill6").html(chasm_save.cSkill6);
		$("#cSkill7").html(chasm_save.cSkill7);
		$("#cSkill8").html(chasm_save.cSkill8);
		$("#cSkill9").html(chasm_save.cSkill9);
		$("#cSkill10").html(chasm_save.cSkill10);
		
		$("#cSkill0_rank").html(chasm_save.cSkill0_rank);
		$("#cSkill1_rank").html(chasm_save.cSkill1_rank);
		$("#cSkill2_rank").html(chasm_save.cSkill2_rank);
		$("#cSkill3_rank").html(chasm_save.cSkill3_rank);
		$("#cSkill4_rank").html(chasm_save.cSkill4_rank);
		$("#cSkill5_rank").html(chasm_save.cSkill5_rank);
		$("#cSkill6_rank").html(chasm_save.cSkill6_rank);
		$("#cSkill7_rank").html(chasm_save.cSkill7_rank);
		$("#cSkill8_rank").html(chasm_save.cSkill8_rank);
		$("#cSkill9_rank").html(chasm_save.cSkill9_rank);
		$("#cSkill10_rank").html(chasm_save.cSkill10_rank);

		if (chasm_save.cSkill0_1) $("#cSkill0_1").prop('checked', true); else $("#cSkill0_1").prop('checked', false);
		if (chasm_save.cSkill0_2) $("#cSkill0_2").prop('checked', true); else $("#cSkill0_2").prop('checked', false);
		if (chasm_save.cSkill0_3) $("#cSkill0_3").prop('checked', true); else $("#cSkill0_3").prop('checked', false);
		if (chasm_save.cSkill0_4) $("#cSkill0_4").prop('checked', true); else $("#cSkill0_4").prop('checked', false);
		if (chasm_save.cSkill0_5) $("#cSkill0_5").prop('checked', true); else $("#cSkill0_5").prop('checked', false);
		if (chasm_save.cSkill0_6) $("#cSkill0_6").prop('checked', true); else $("#cSkill0_6").prop('checked', false);

		if (chasm_save.cSkill1_1) $("#cSkill1_1").prop('checked', true); else $("#cSkill1_1").prop('checked', false);
		if (chasm_save.cSkill1_2) $("#cSkill1_2").prop('checked', true); else $("#cSkill1_2").prop('checked', false);
		if (chasm_save.cSkill1_3) $("#cSkill1_3").prop('checked', true); else $("#cSkill1_3").prop('checked', false);
		if (chasm_save.cSkill1_4) $("#cSkill1_4").prop('checked', true); else $("#cSkill1_4").prop('checked', false);
		if (chasm_save.cSkill1_5) $("#cSkill1_5").prop('checked', true); else $("#cSkill1_5").prop('checked', false);
		if (chasm_save.cSkill1_6) $("#cSkill1_6").prop('checked', true); else $("#cSkill1_6").prop('checked', false);

		if (chasm_save.cSkill2_1) $("#cSkill2_1").prop('checked', true); else $("#cSkill2_1").prop('checked', false);
		if (chasm_save.cSkill2_2) $("#cSkill2_2").prop('checked', true); else $("#cSkill2_2").prop('checked', false);
		if (chasm_save.cSkill2_3) $("#cSkill2_3").prop('checked', true); else $("#cSkill2_3").prop('checked', false);
		if (chasm_save.cSkill2_4) $("#cSkill2_4").prop('checked', true); else $("#cSkill2_4").prop('checked', false);
		if (chasm_save.cSkill2_5) $("#cSkill2_5").prop('checked', true); else $("#cSkill2_5").prop('checked', false);
		if (chasm_save.cSkill2_6) $("#cSkill2_6").prop('checked', true); else $("#cSkill2_6").prop('checked', false);

		if (chasm_save.cSkill3_1) $("#cSkill3_1").prop('checked', true); else $("#cSkill3_1").prop('checked', false);
		if (chasm_save.cSkill3_2) $("#cSkill3_2").prop('checked', true); else $("#cSkill3_2").prop('checked', false);
		if (chasm_save.cSkill3_3) $("#cSkill3_3").prop('checked', true); else $("#cSkill3_3").prop('checked', false);
		if (chasm_save.cSkill3_4) $("#cSkill3_4").prop('checked', true); else $("#cSkill3_4").prop('checked', false);
		if (chasm_save.cSkill3_5) $("#cSkill3_5").prop('checked', true); else $("#cSkill3_5").prop('checked', false);
		if (chasm_save.cSkill3_6) $("#cSkill3_6").prop('checked', true); else $("#cSkill3_6").prop('checked', false);

		if (chasm_save.cSkill4_1) $("#cSkill4_1").prop('checked', true); else $("#cSkill4_1").prop('checked', false);
		if (chasm_save.cSkill4_2) $("#cSkill4_2").prop('checked', true); else $("#cSkill4_2").prop('checked', false);
		if (chasm_save.cSkill4_3) $("#cSkill4_3").prop('checked', true); else $("#cSkill4_3").prop('checked', false);
		if (chasm_save.cSkill4_4) $("#cSkill4_4").prop('checked', true); else $("#cSkill4_4").prop('checked', false);
		if (chasm_save.cSkill4_5) $("#cSkill4_5").prop('checked', true); else $("#cSkill4_5").prop('checked', false);
		if (chasm_save.cSkill4_6) $("#cSkill4_6").prop('checked', true); else $("#cSkill4_6").prop('checked', false);

		if (chasm_save.cSkill5_1) $("#cSkill5_1").prop('checked', true); else $("#cSkill5_1").prop('checked', false);
		if (chasm_save.cSkill5_2) $("#cSkill5_2").prop('checked', true); else $("#cSkill5_2").prop('checked', false);
		if (chasm_save.cSkill5_3) $("#cSkill5_3").prop('checked', true); else $("#cSkill5_3").prop('checked', false);
		if (chasm_save.cSkill5_4) $("#cSkill5_4").prop('checked', true); else $("#cSkill5_4").prop('checked', false);
		if (chasm_save.cSkill5_5) $("#cSkill5_5").prop('checked', true); else $("#cSkill5_5").prop('checked', false);
		if (chasm_save.cSkill5_6) $("#cSkill5_6").prop('checked', true); else $("#cSkill5_6").prop('checked', false);

		if (chasm_save.cSkill6_1) $("#cSkill6_1").prop('checked', true); else $("#cSkill6_1").prop('checked', false);
		if (chasm_save.cSkill6_2) $("#cSkill6_2").prop('checked', true); else $("#cSkill6_2").prop('checked', false);
		if (chasm_save.cSkill6_3) $("#cSkill6_3").prop('checked', true); else $("#cSkill6_3").prop('checked', false);
		if (chasm_save.cSkill6_4) $("#cSkill6_4").prop('checked', true); else $("#cSkill6_4").prop('checked', false);
		if (chasm_save.cSkill6_5) $("#cSkill6_5").prop('checked', true); else $("#cSkill6_5").prop('checked', false);
		if (chasm_save.cSkill6_6) $("#cSkill6_6").prop('checked', true); else $("#cSkill6_6").prop('checked', false);

		if (chasm_save.cSkill7_1) $("#cSkill7_1").prop('checked', true); else $("#cSkill7_1").prop('checked', false);
		if (chasm_save.cSkill7_2) $("#cSkill7_2").prop('checked', true); else $("#cSkill7_2").prop('checked', false);
		if (chasm_save.cSkill7_3) $("#cSkill7_3").prop('checked', true); else $("#cSkill7_3").prop('checked', false);
		if (chasm_save.cSkill7_4) $("#cSkill7_4").prop('checked', true); else $("#cSkill7_4").prop('checked', false);
		if (chasm_save.cSkill7_5) $("#cSkill7_5").prop('checked', true); else $("#cSkill7_5").prop('checked', false);
		if (chasm_save.cSkill7_6) $("#cSkill7_6").prop('checked', true); else $("#cSkill7_6").prop('checked', false);

		if (chasm_save.cSkill8_1) $("#cSkill8_1").prop('checked', true); else $("#cSkill8_1").prop('checked', false);
		if (chasm_save.cSkill8_2) $("#cSkill8_2").prop('checked', true); else $("#cSkill8_2").prop('checked', false);
		if (chasm_save.cSkill8_3) $("#cSkill8_3").prop('checked', true); else $("#cSkill8_3").prop('checked', false);
		if (chasm_save.cSkill8_4) $("#cSkill8_4").prop('checked', true); else $("#cSkill8_4").prop('checked', false);
		if (chasm_save.cSkill8_5) $("#cSkill8_5").prop('checked', true); else $("#cSkill8_5").prop('checked', false);
		if (chasm_save.cSkill8_6) $("#cSkill8_6").prop('checked', true); else $("#cSkill8_6").prop('checked', false);

		if (chasm_save.cSkill9_1) $("#cSkill9_1").prop('checked', true); else $("#cSkill9_1").prop('checked', false);
		if (chasm_save.cSkill9_2) $("#cSkill9_2").prop('checked', true); else $("#cSkill9_2").prop('checked', false);
		if (chasm_save.cSkill9_3) $("#cSkill9_3").prop('checked', true); else $("#cSkill9_3").prop('checked', false);
		if (chasm_save.cSkill9_4) $("#cSkill9_4").prop('checked', true); else $("#cSkill9_4").prop('checked', false);
		if (chasm_save.cSkill9_5) $("#cSkill9_5").prop('checked', true); else $("#cSkill9_5").prop('checked', false);
		if (chasm_save.cSkill9_6) $("#cSkill9_6").prop('checked', true); else $("#cSkill9_6").prop('checked', false);

		if (chasm_save.cSkill10_1) $("#cSkill10_1").prop('checked', true); else $("#cSkill10_1").prop('checked', false);
		if (chasm_save.cSkill10_2) $("#cSkill10_2").prop('checked', true); else $("#cSkill10_2").prop('checked', false);
		if (chasm_save.cSkill10_3) $("#cSkill10_3").prop('checked', true); else $("#cSkill10_3").prop('checked', false);
		if (chasm_save.cSkill10_4) $("#cSkill10_4").prop('checked', true); else $("#cSkill10_4").prop('checked', false);
		if (chasm_save.cSkill10_5) $("#cSkill10_5").prop('checked', true); else $("#cSkill10_5").prop('checked', false);
		if (chasm_save.cSkill10_6) $("#cSkill10_6").prop('checked', true); else $("#cSkill10_6").prop('checked', false);
		
		$("#nSkill0").html(chasm_save.nSkill0);
		$("#nSkill1").html(chasm_save.nSkill1);
		$("#nSkill2").html(chasm_save.nSkill2);
		$("#nSkill3").html(chasm_save.nSkill3);
		$("#nSkill4").html(chasm_save.nSkill4);
		$("#nSkill5").html(chasm_save.nSkill5);
		$("#nSkill6").html(chasm_save.nSkill6);
		$("#nSkill7").html(chasm_save.nSkill7);
		$("#nSkill8").html(chasm_save.nSkill8);
		$("#nSkill9").html(chasm_save.nSkill9);
		$("#nSkill10").html(chasm_save.nSkill10);
		$("#nSkill11").html(chasm_save.nSkill11);
		$("#nSkill12").html(chasm_save.nSkill12);
		$("#nSkill13").html(chasm_save.nSkill13);
		$("#nSkill14").html(chasm_save.nSkill14);
		$("#nSkill15").html(chasm_save.nSkill15);
		$("#nSkill16").html(chasm_save.nSkill16);
		$("#nSkill17").html(chasm_save.nSkill17);
		$("#nSkill18").html(chasm_save.nSkill18);
		
		$("#nSkill0_rank").html(chasm_save.nSkill0_rank);
		$("#nSkill1_rank").html(chasm_save.nSkill1_rank);
		$("#nSkill2_rank").html(chasm_save.nSkill2_rank);
		$("#nSkill3_rank").html(chasm_save.nSkill3_rank);
		$("#nSkill4_rank").html(chasm_save.nSkill4_rank);
		$("#nSkill5_rank").html(chasm_save.nSkill5_rank);
		$("#nSkill6_rank").html(chasm_save.nSkill6_rank);
		$("#nSkill7_rank").html(chasm_save.nSkill7_rank);
		$("#nSkill8_rank").html(chasm_save.nSkill8_rank);
		$("#nSkill9_rank").html(chasm_save.nSkill9_rank);
		$("#nSkill10_rank").html(chasm_save.nSkill10_rank);
		$("#nSkill11_rank").html(chasm_save.nSkill11_rank);
		$("#nSkill12_rank").html(chasm_save.nSkill12_rank);
		$("#nSkill13_rank").html(chasm_save.nSkill13_rank);
		$("#nSkill14_rank").html(chasm_save.nSkill14_rank);
		$("#nSkill15_rank").html(chasm_save.nSkill15_rank);
		$("#nSkill16_rank").html(chasm_save.nSkill16_rank);
		$("#nSkill17_rank").html(chasm_save.nSkill17_rank);
		$("#nSkill18_rank").html(chasm_save.nSkill18_rank);

		if (chasm_save.nSkill0_1) $("#nSkill0_1").prop('checked', true); else $("#nSkill0_1").prop('checked', false);
		if (chasm_save.nSkill0_2) $("#nSkill0_2").prop('checked', true); else $("#nSkill0_2").prop('checked', false);
		if (chasm_save.nSkill0_3) $("#nSkill0_3").prop('checked', true); else $("#nSkill0_3").prop('checked', false);
		if (chasm_save.nSkill0_4) $("#nSkill0_4").prop('checked', true); else $("#nSkill0_4").prop('checked', false);
		if (chasm_save.nSkill0_5) $("#nSkill0_5").prop('checked', true); else $("#nSkill0_5").prop('checked', false);
		if (chasm_save.nSkill0_6) $("#nSkill0_6").prop('checked', true); else $("#nSkill0_6").prop('checked', false);

		if (chasm_save.nSkill1_1) $("#nSkill1_1").prop('checked', true); else $("#nSkill1_1").prop('checked', false);
		if (chasm_save.nSkill1_2) $("#nSkill1_2").prop('checked', true); else $("#nSkill1_2").prop('checked', false);
		if (chasm_save.nSkill1_3) $("#nSkill1_3").prop('checked', true); else $("#nSkill1_3").prop('checked', false);
		if (chasm_save.nSkill1_4) $("#nSkill1_4").prop('checked', true); else $("#nSkill1_4").prop('checked', false);
		if (chasm_save.nSkill1_5) $("#nSkill1_5").prop('checked', true); else $("#nSkill1_5").prop('checked', false);
		if (chasm_save.nSkill1_6) $("#nSkill1_6").prop('checked', true); else $("#nSkill1_6").prop('checked', false);

		if (chasm_save.nSkill2_1) $("#nSkill2_1").prop('checked', true); else $("#nSkill2_1").prop('checked', false);
		if (chasm_save.nSkill2_2) $("#nSkill2_2").prop('checked', true); else $("#nSkill2_2").prop('checked', false);
		if (chasm_save.nSkill2_3) $("#nSkill2_3").prop('checked', true); else $("#nSkill2_3").prop('checked', false);
		if (chasm_save.nSkill2_4) $("#nSkill2_4").prop('checked', true); else $("#nSkill2_4").prop('checked', false);
		if (chasm_save.nSkill2_5) $("#nSkill2_5").prop('checked', true); else $("#nSkill2_5").prop('checked', false);
		if (chasm_save.nSkill2_6) $("#nSkill2_6").prop('checked', true); else $("#nSkill2_6").prop('checked', false);

		if (chasm_save.nSkill3_1) $("#nSkill3_1").prop('checked', true); else $("#nSkill3_1").prop('checked', false);
		if (chasm_save.nSkill3_2) $("#nSkill3_2").prop('checked', true); else $("#nSkill3_2").prop('checked', false);
		if (chasm_save.nSkill3_3) $("#nSkill3_3").prop('checked', true); else $("#nSkill3_3").prop('checked', false);
		if (chasm_save.nSkill3_4) $("#nSkill3_4").prop('checked', true); else $("#nSkill3_4").prop('checked', false);
		if (chasm_save.nSkill3_5) $("#nSkill3_5").prop('checked', true); else $("#nSkill3_5").prop('checked', false);
		if (chasm_save.nSkill3_6) $("#nSkill3_6").prop('checked', true); else $("#nSkill3_6").prop('checked', false);

		if (chasm_save.nSkill4_1) $("#nSkill4_1").prop('checked', true); else $("#nSkill4_1").prop('checked', false);
		if (chasm_save.nSkill4_2) $("#nSkill4_2").prop('checked', true); else $("#nSkill4_2").prop('checked', false);
		if (chasm_save.nSkill4_3) $("#nSkill4_3").prop('checked', true); else $("#nSkill4_3").prop('checked', false);
		if (chasm_save.nSkill4_4) $("#nSkill4_4").prop('checked', true); else $("#nSkill4_4").prop('checked', false);
		if (chasm_save.nSkill4_5) $("#nSkill4_5").prop('checked', true); else $("#nSkill4_5").prop('checked', false);
		if (chasm_save.nSkill4_6) $("#nSkill4_6").prop('checked', true); else $("#nSkill4_6").prop('checked', false);

		if (chasm_save.nSkill5_1) $("#nSkill5_1").prop('checked', true); else $("#nSkill5_1").prop('checked', false);
		if (chasm_save.nSkill5_2) $("#nSkill5_2").prop('checked', true); else $("#nSkill5_2").prop('checked', false);
		if (chasm_save.nSkill5_3) $("#nSkill5_3").prop('checked', true); else $("#nSkill5_3").prop('checked', false);
		if (chasm_save.nSkill5_4) $("#nSkill5_4").prop('checked', true); else $("#nSkill5_4").prop('checked', false);
		if (chasm_save.nSkill5_5) $("#nSkill5_5").prop('checked', true); else $("#nSkill5_5").prop('checked', false);
		if (chasm_save.nSkill5_6) $("#nSkill5_6").prop('checked', true); else $("#nSkill5_6").prop('checked', false);

		if (chasm_save.nSkill6_1) $("#nSkill6_1").prop('checked', true); else $("#nSkill6_1").prop('checked', false);
		if (chasm_save.nSkill6_2) $("#nSkill6_2").prop('checked', true); else $("#nSkill6_2").prop('checked', false);
		if (chasm_save.nSkill6_3) $("#nSkill6_3").prop('checked', true); else $("#nSkill6_3").prop('checked', false);
		if (chasm_save.nSkill6_4) $("#nSkill6_4").prop('checked', true); else $("#nSkill6_4").prop('checked', false);
		if (chasm_save.nSkill6_5) $("#nSkill6_5").prop('checked', true); else $("#nSkill6_5").prop('checked', false);
		if (chasm_save.nSkill6_6) $("#nSkill6_6").prop('checked', true); else $("#nSkill6_6").prop('checked', false);

		if (chasm_save.nSkill7_1) $("#nSkill7_1").prop('checked', true); else $("#nSkill7_1").prop('checked', false);
		if (chasm_save.nSkill7_2) $("#nSkill7_2").prop('checked', true); else $("#nSkill7_2").prop('checked', false);
		if (chasm_save.nSkill7_3) $("#nSkill7_3").prop('checked', true); else $("#nSkill7_3").prop('checked', false);
		if (chasm_save.nSkill7_4) $("#nSkill7_4").prop('checked', true); else $("#nSkill7_4").prop('checked', false);
		if (chasm_save.nSkill7_5) $("#nSkill7_5").prop('checked', true); else $("#nSkill7_5").prop('checked', false);
		if (chasm_save.nSkill7_6) $("#nSkill7_6").prop('checked', true); else $("#nSkill7_6").prop('checked', false);

		if (chasm_save.nSkill8_1) $("#nSkill8_1").prop('checked', true); else $("#nSkill8_1").prop('checked', false);
		if (chasm_save.nSkill8_2) $("#nSkill8_2").prop('checked', true); else $("#nSkill8_2").prop('checked', false);
		if (chasm_save.nSkill8_3) $("#nSkill8_3").prop('checked', true); else $("#nSkill8_3").prop('checked', false);
		if (chasm_save.nSkill8_4) $("#nSkill8_4").prop('checked', true); else $("#nSkill8_4").prop('checked', false);
		if (chasm_save.nSkill8_5) $("#nSkill8_5").prop('checked', true); else $("#nSkill8_5").prop('checked', false);
		if (chasm_save.nSkill8_6) $("#nSkill8_6").prop('checked', true); else $("#nSkill8_6").prop('checked', false);

		if (chasm_save.nSkill9_1) $("#nSkill9_1").prop('checked', true); else $("#nSkill9_1").prop('checked', false);
		if (chasm_save.nSkill9_2) $("#nSkill9_2").prop('checked', true); else $("#nSkill9_2").prop('checked', false);
		if (chasm_save.nSkill9_3) $("#nSkill9_3").prop('checked', true); else $("#nSkill9_3").prop('checked', false);
		if (chasm_save.nSkill9_4) $("#nSkill9_4").prop('checked', true); else $("#nSkill9_4").prop('checked', false);
		if (chasm_save.nSkill9_5) $("#nSkill9_5").prop('checked', true); else $("#nSkill9_5").prop('checked', false);
		if (chasm_save.nSkill9_6) $("#nSkill9_6").prop('checked', true); else $("#nSkill9_6").prop('checked', false);

		if (chasm_save.nSkill10_1) $("#nSkill10_1").prop('checked', true); else $("#nSkill10_1").prop('checked', false);
		if (chasm_save.nSkill10_2) $("#nSkill10_2").prop('checked', true); else $("#nSkill10_2").prop('checked', false);
		if (chasm_save.nSkill10_3) $("#nSkill10_3").prop('checked', true); else $("#nSkill10_3").prop('checked', false);
		if (chasm_save.nSkill10_4) $("#nSkill10_4").prop('checked', true); else $("#nSkill10_4").prop('checked', false);
		if (chasm_save.nSkill10_5) $("#nSkill10_5").prop('checked', true); else $("#nSkill10_5").prop('checked', false);
		if (chasm_save.nSkill10_6) $("#nSkill10_6").prop('checked', true); else $("#nSkill10_6").prop('checked', false);

		if (chasm_save.nSkill11_1) $("#nSkill11_1").prop('checked', true); else $("#nSkill11_1").prop('checked', false);
		if (chasm_save.nSkill11_2) $("#nSkill11_2").prop('checked', true); else $("#nSkill11_2").prop('checked', false);
		if (chasm_save.nSkill11_3) $("#nSkill11_3").prop('checked', true); else $("#nSkill11_3").prop('checked', false);
		if (chasm_save.nSkill11_4) $("#nSkill11_4").prop('checked', true); else $("#nSkill11_4").prop('checked', false);
		if (chasm_save.nSkill11_5) $("#nSkill11_5").prop('checked', true); else $("#nSkill11_5").prop('checked', false);
		if (chasm_save.nSkill11_6) $("#nSkill11_6").prop('checked', true); else $("#nSkill11_6").prop('checked', false);

		if (chasm_save.nSkill12_1) $("#nSkill12_1").prop('checked', true); else $("#nSkill12_1").prop('checked', false);
		if (chasm_save.nSkill12_2) $("#nSkill12_2").prop('checked', true); else $("#nSkill12_2").prop('checked', false);
		if (chasm_save.nSkill12_3) $("#nSkill12_3").prop('checked', true); else $("#nSkill12_3").prop('checked', false);
		if (chasm_save.nSkill12_4) $("#nSkill12_4").prop('checked', true); else $("#nSkill12_4").prop('checked', false);
		if (chasm_save.nSkill12_5) $("#nSkill12_5").prop('checked', true); else $("#nSkill12_5").prop('checked', false);
		if (chasm_save.nSkill12_6) $("#nSkill12_6").prop('checked', true); else $("#nSkill12_6").prop('checked', false);

		if (chasm_save.nSkill13_1) $("#nSkill13_1").prop('checked', true); else $("#nSkill13_1").prop('checked', false);
		if (chasm_save.nSkill13_2) $("#nSkill13_2").prop('checked', true); else $("#nSkill13_2").prop('checked', false);
		if (chasm_save.nSkill13_3) $("#nSkill13_3").prop('checked', true); else $("#nSkill13_3").prop('checked', false);
		if (chasm_save.nSkill13_4) $("#nSkill13_4").prop('checked', true); else $("#nSkill13_4").prop('checked', false);
		if (chasm_save.nSkill13_5) $("#nSkill13_5").prop('checked', true); else $("#nSkill13_5").prop('checked', false);
		if (chasm_save.nSkill13_6) $("#nSkill13_6").prop('checked', true); else $("#nSkill13_6").prop('checked', false);

		if (chasm_save.nSkill14_1) $("#nSkill14_1").prop('checked', true); else $("#nSkill14_1").prop('checked', false);
		if (chasm_save.nSkill14_2) $("#nSkill14_2").prop('checked', true); else $("#nSkill14_2").prop('checked', false);
		if (chasm_save.nSkill14_3) $("#nSkill14_3").prop('checked', true); else $("#nSkill14_3").prop('checked', false);
		if (chasm_save.nSkill14_4) $("#nSkill14_4").prop('checked', true); else $("#nSkill14_4").prop('checked', false);
		if (chasm_save.nSkill14_5) $("#nSkill14_5").prop('checked', true); else $("#nSkill14_5").prop('checked', false);
		if (chasm_save.nSkill14_6) $("#nSkill14_6").prop('checked', true); else $("#nSkill14_6").prop('checked', false);

		if (chasm_save.nSkill15_1) $("#nSkill15_1").prop('checked', true); else $("#nSkill15_1").prop('checked', false);
		if (chasm_save.nSkill15_2) $("#nSkill15_2").prop('checked', true); else $("#nSkill15_2").prop('checked', false);
		if (chasm_save.nSkill15_3) $("#nSkill15_3").prop('checked', true); else $("#nSkill15_3").prop('checked', false);
		if (chasm_save.nSkill15_4) $("#nSkill15_4").prop('checked', true); else $("#nSkill15_4").prop('checked', false);
		if (chasm_save.nSkill15_5) $("#nSkill15_5").prop('checked', true); else $("#nSkill15_5").prop('checked', false);
		if (chasm_save.nSkill15_6) $("#nSkill15_6").prop('checked', true); else $("#nSkill15_6").prop('checked', false);

		if (chasm_save.nSkill16_1) $("#nSkill16_1").prop('checked', true); else $("#nSkill16_1").prop('checked', false);
		if (chasm_save.nSkill16_2) $("#nSkill16_2").prop('checked', true); else $("#nSkill16_2").prop('checked', false);
		if (chasm_save.nSkill16_3) $("#nSkill16_3").prop('checked', true); else $("#nSkill16_3").prop('checked', false);
		if (chasm_save.nSkill16_4) $("#nSkill16_4").prop('checked', true); else $("#nSkill16_4").prop('checked', false);
		if (chasm_save.nSkill16_5) $("#nSkill16_5").prop('checked', true); else $("#nSkill16_5").prop('checked', false);
		if (chasm_save.nSkill16_6) $("#nSkill16_6").prop('checked', true); else $("#nSkill16_6").prop('checked', false);

		if (chasm_save.nSkill17_1) $("#nSkill17_1").prop('checked', true); else $("#nSkill17_1").prop('checked', false);
		if (chasm_save.nSkill17_2) $("#nSkill17_2").prop('checked', true); else $("#nSkill17_2").prop('checked', false);
		if (chasm_save.nSkill17_3) $("#nSkill17_3").prop('checked', true); else $("#nSkill17_3").prop('checked', false);
		if (chasm_save.nSkill17_4) $("#nSkill17_4").prop('checked', true); else $("#nSkill17_4").prop('checked', false);
		if (chasm_save.nSkill17_5) $("#nSkill17_5").prop('checked', true); else $("#nSkill17_5").prop('checked', false);
		if (chasm_save.nSkill17_6) $("#nSkill17_6").prop('checked', true); else $("#nSkill17_6").prop('checked', false);

		if (chasm_save.nSkill18_1) $("#nSkill18_1").prop('checked', true); else $("#nSkill18_1").prop('checked', false);
		if (chasm_save.nSkill18_2) $("#nSkill18_2").prop('checked', true); else $("#nSkill18_2").prop('checked', false);
		if (chasm_save.nSkill18_3) $("#nSkill18_3").prop('checked', true); else $("#nSkill18_3").prop('checked', false);
		if (chasm_save.nSkill18_4) $("#nSkill18_4").prop('checked', true); else $("#nSkill18_4").prop('checked', false);
		if (chasm_save.nSkill18_5) $("#nSkill18_5").prop('checked', true); else $("#nSkill18_5").prop('checked', false);
		if (chasm_save.nSkill18_6) $("#nSkill18_6").prop('checked', true); else $("#nSkill18_6").prop('checked', false);

		if (chasm_save.wClarityLight1) $("#wClarityLight1").prop('checked', true); else $("#wClarityLight1").prop('checked', false);
		if (chasm_save.wClarityLight2) $("#wClarityLight2").prop('checked', true); else $("#wClarityLight2").prop('checked', false);
		if (chasm_save.wClarityLight3) $("#wClarityLight3").prop('checked', true); else $("#wClarityLight3").prop('checked', false);
		if (chasm_save.wClarityLight4) $("#wClarityLight4").prop('checked', true); else $("#wClarityLight4").prop('checked', false);
	
		if (chasm_save.wClaritySevere1) $("#wClaritySevere1").prop('checked', true); else $("#wClaritySevere1").prop('checked', false);
		if (chasm_save.wClaritySevere2) $("#wClaritySevere2").prop('checked', true); else $("#wClaritySevere2").prop('checked', false);
		if (chasm_save.wClaritySevere3) $("#wClaritySevere3").prop('checked', true); else $("#wClaritySevere3").prop('checked', false);
		if (chasm_save.wClaritySevere4) $("#wClaritySevere4").prop('checked', true); else $("#wClaritySevere4").prop('checked', false);
	
		if (chasm_save.wClarityCritical1) $("#wClarityCritical1").prop('checked', true); else $("#wClarityCritical1").prop('checked', false);
		if (chasm_save.wClarityCritical2) $("#wClarityCritical2").prop('checked', true); else $("#wClarityCritical2").prop('checked', false);
	
		if (chasm_save.wHealthLight1) $("#wHealthLight1").prop('checked', true); else $("#wHealthLight1").prop('checked', false);
		if (chasm_save.wHealthLight2) $("#wHealthLight2").prop('checked', true); else $("#wHealthLight2").prop('checked', false);
		if (chasm_save.wHealthLight3) $("#wHealthLight3").prop('checked', true); else $("#wHealthLight3").prop('checked', false);
		if (chasm_save.wHealthLight4) $("#wHealthLight4").prop('checked', true); else $("#wHealthLight4").prop('checked', false);

		if (chasm_save.wHealthSevere1) $("#wHealthSevere1").prop('checked', true); else $("#wHealthSevere1").prop('checked', false);
		if (chasm_save.wHealthSevere2) $("#wHealthSevere2").prop('checked', true); else $("#wHealthSevere2").prop('checked', false);
		if (chasm_save.wHealthSevere3) $("#wHealthSevere3").prop('checked', true); else $("#wHealthSevere3").prop('checked', false);
		if (chasm_save.wHealthSevere4) $("#wHealthSevere4").prop('checked', true); else $("#wHealthSevere4").prop('checked', false);

		if (chasm_save.wHealthCritical1) $("#wHealthCritical1").prop('checked', true); else $("#wHealthCritical1").prop('checked', false);
		if (chasm_save.wHealthCritical2) $("#wHealthCritical2").prop('checked', true); else $("#wHealthCritical2").prop('checked', false);

		if (chasm_save.wStressLight1) $("#wStressLight1").prop('checked', true); else $("#wStressLight1").prop('checked', false);
		if (chasm_save.wStressLight2) $("#wStressLight2").prop('checked', true); else $("#wStressLight2").prop('checked', false);
		if (chasm_save.wStressLight3) $("#wStressLight3").prop('checked', true); else $("#wStressLight3").prop('checked', false);
		if (chasm_save.wStressLight4) $("#wStressLight4").prop('checked', true); else $("#wStressLight4").prop('checked', false);

		if (chasm_save.wStressSevere1) $("#wStressSevere1").prop('checked', true); else $("#wStressSevere1").prop('checked', false);
		if (chasm_save.wStressSevere2) $("#wStressSevere2").prop('checked', true); else $("#wStressSevere2").prop('checked', false);
		if (chasm_save.wStressSevere3) $("#wStressSevere3").prop('checked', true); else $("#wStressSevere3").prop('checked', false);
		if (chasm_save.wStressSevere4) $("#wStressSevere4").prop('checked', true); else $("#wStressSevere4").prop('checked', false);

		if (chasm_save.wStressCritical1) $("#wStressCritical1").prop('checked', true); else $("#wStressCritical1").prop('checked', false);
		if (chasm_save.wStressCritical2) $("#wStressCritical2").prop('checked', true); else $("#wStressCritical2").prop('checked', false);
	}
}

function generateSave() {
	chasm_save.saveCount++;

	chasm_save.attrPer 	= $("#attrPer").html();
	chasm_save.attrFoc 	= $("#attrFoc").html();
	chasm_save.attrDex 	= $("#attrDex").html();
	chasm_save.attrVit 	= $("#attrVit").html();
	chasm_save.attrCha 	= $("#attrCha").html();
	chasm_save.attrWil 	= $("#attrWil").html();
	
	chasm_save.charName 		= $("#charName").html();
	chasm_save.charArchetype 	= $("#charArchetype").html();
	chasm_save.charBackground 	= $("#charBackground").html();
	chasm_save.charMotivation 	= $("#charMotivation").html();
	chasm_save.charMotivation2 	= $("#charMotivation2").html();
	chasm_save.charMotivation3 	= $("#charMotivation3").html();
	chasm_save.charFears 		= $("#charFears").html();
	chasm_save.charGoal 		= $("#charGoal").html();
	
	chasm_save.motCheck1 = $("#motCheck1").is(":checked");
	chasm_save.motCheck2 = $("#motCheck2").is(":checked");
	chasm_save.motCheck3 = $("#motCheck3").is(":checked");
	chasm_save.motCheck4 = $("#motCheck4").is(":checked");

	chasm_save.motCheck1		= $("#motCheck1").is(":checked");
	chasm_save.motCheck2		= $("#motCheck2").is(":checked");
	chasm_save.motCheck3		= $("#motCheck3").is(":checked");
	chasm_save.motCheck4		= $("#motCheck4").is(":checked");

	chasm_save.charConditions 	= $("#charConditions").html();
	chasm_save.charAcclimations = $("#charAcclimations").html();
	chasm_save.charExperience 	= $("#charExperience").html();

	chasm_save.charEquipment	= $("#charEquipment").html();

	chasm_save.humanityCurrent 	= $("#humanityCurrent").html();
	chasm_save.humanityMax 		= $("#humanityMax").html();
	
	chasm_save.mementoMori		= $("#mementoMori").html();

	chasm_save.thresholdDanger 	= $("#thresholdDanger").html();
	chasm_save.thresholdDespair = $("#thresholdDespair").html();
	chasm_save.thresholdDisgust = $("#thresholdDisgust").html();

	chasm_save.charNotes 		= $("#charNotes").html();
	chasm_save.charAbilities 	= $("#charAbilities").html();
		
	chasm_save.strainMentalCurrent 		= $("#strainMentalCurrent").html();
	chasm_save.strainPhysicalCurrent 	= $("#strainPhysicalCurrent").html();
	chasm_save.strainSpiritualCurrent 	= $("#strainSpiritualCurrent").html();

	chasm_save.cSkill0	= $("#cSkill0").html();
	chasm_save.cSkill1	= $("#cSkill1").html();
	chasm_save.cSkill2	= $("#cSkill2").html();
	chasm_save.cSkill3	= $("#cSkill3").html();
	chasm_save.cSkill4	= $("#cSkill4").html();
	chasm_save.cSkill5	= $("#cSkill5").html();
	chasm_save.cSkill6	= $("#cSkill6").html();
	chasm_save.cSkill7	= $("#cSkill7").html();
	chasm_save.cSkill8	= $("#cSkill8").html();
	chasm_save.cSkill9	= $("#cSkill9").html();
	chasm_save.cSkill10	= $("#cSkill10").html();

	chasm_save.cSkill0_rank		= $("#cSkill0_rank").html();
	chasm_save.cSkill1_rank		= $("#cSkill1_rank").html();
	chasm_save.cSkill2_rank		= $("#cSkill2_rank").html();
	chasm_save.cSkill3_rank		= $("#cSkill3_rank").html();
	chasm_save.cSkill4_rank		= $("#cSkill4_rank").html();
	chasm_save.cSkill5_rank		= $("#cSkill5_rank").html();
	chasm_save.cSkill6_rank		= $("#cSkill6_rank").html();
	chasm_save.cSkill7_rank		= $("#cSkill7_rank").html();
	chasm_save.cSkill8_rank		= $("#cSkill8_rank").html();
	chasm_save.cSkill9_rank		= $("#cSkill9_rank").html();
	chasm_save.cSkill10_rank	= $("#cSkill10_rank").html();

	chasm_save.cSkill0_1 = $("#cSkill0_1").is(":checked");
	chasm_save.cSkill0_2 = $("#cSkill0_2").is(":checked");
	chasm_save.cSkill0_3 = $("#cSkill0_3").is(":checked");
	chasm_save.cSkill0_4 = $("#cSkill0_4").is(":checked");
	chasm_save.cSkill0_5 = $("#cSkill0_5").is(":checked");
	chasm_save.cSkill0_6 = $("#cSkill0_6").is(":checked");

	chasm_save.cSkill1_1 = $("#cSkill1_1").is(":checked");
	chasm_save.cSkill1_2 = $("#cSkill1_2").is(":checked");
	chasm_save.cSkill1_3 = $("#cSkill1_3").is(":checked");
	chasm_save.cSkill1_4 = $("#cSkill1_4").is(":checked");
	chasm_save.cSkill1_5 = $("#cSkill1_5").is(":checked");
	chasm_save.cSkill1_6 = $("#cSkill1_6").is(":checked");

	chasm_save.cSkill2_1 = $("#cSkill2_1").is(":checked");
	chasm_save.cSkill2_2 = $("#cSkill2_2").is(":checked");
	chasm_save.cSkill2_3 = $("#cSkill2_3").is(":checked");
	chasm_save.cSkill2_4 = $("#cSkill2_4").is(":checked");
	chasm_save.cSkill2_5 = $("#cSkill2_5").is(":checked");
	chasm_save.cSkill2_6 = $("#cSkill2_6").is(":checked");

	chasm_save.cSkill3_1 = $("#cSkill3_1").is(":checked");
	chasm_save.cSkill3_2 = $("#cSkill3_2").is(":checked");
	chasm_save.cSkill3_3 = $("#cSkill3_3").is(":checked");
	chasm_save.cSkill3_4 = $("#cSkill3_4").is(":checked");
	chasm_save.cSkill3_5 = $("#cSkill3_5").is(":checked");
	chasm_save.cSkill3_6 = $("#cSkill3_6").is(":checked");

	chasm_save.cSkill4_1 = $("#cSkill4_1").is(":checked");
	chasm_save.cSkill4_2 = $("#cSkill4_2").is(":checked");
	chasm_save.cSkill4_3 = $("#cSkill4_3").is(":checked");
	chasm_save.cSkill4_4 = $("#cSkill4_4").is(":checked");
	chasm_save.cSkill4_5 = $("#cSkill4_5").is(":checked");
	chasm_save.cSkill4_6 = $("#cSkill4_6").is(":checked");

	chasm_save.cSkill5_1 = $("#cSkill5_1").is(":checked");
	chasm_save.cSkill5_2 = $("#cSkill5_2").is(":checked");
	chasm_save.cSkill5_3 = $("#cSkill5_3").is(":checked");
	chasm_save.cSkill5_4 = $("#cSkill5_4").is(":checked");
	chasm_save.cSkill5_5 = $("#cSkill5_5").is(":checked");
	chasm_save.cSkill5_6 = $("#cSkill5_6").is(":checked");

	chasm_save.cSkill6_1 = $("#cSkill6_1").is(":checked");
	chasm_save.cSkill6_2 = $("#cSkill6_2").is(":checked");
	chasm_save.cSkill6_3 = $("#cSkill6_3").is(":checked");
	chasm_save.cSkill6_4 = $("#cSkill6_4").is(":checked");
	chasm_save.cSkill6_5 = $("#cSkill6_5").is(":checked");
	chasm_save.cSkill6_6 = $("#cSkill6_6").is(":checked");

	chasm_save.cSkill7_1 = $("#cSkill7_1").is(":checked");
	chasm_save.cSkill7_2 = $("#cSkill7_2").is(":checked");
	chasm_save.cSkill7_3 = $("#cSkill7_3").is(":checked");
	chasm_save.cSkill7_4 = $("#cSkill7_4").is(":checked");
	chasm_save.cSkill7_5 = $("#cSkill7_5").is(":checked");
	chasm_save.cSkill7_6 = $("#cSkill7_6").is(":checked");

	chasm_save.cSkill8_1 = $("#cSkill8_1").is(":checked");
	chasm_save.cSkill8_2 = $("#cSkill8_2").is(":checked");
	chasm_save.cSkill8_3 = $("#cSkill8_3").is(":checked");
	chasm_save.cSkill8_4 = $("#cSkill8_4").is(":checked");
	chasm_save.cSkill8_5 = $("#cSkill8_5").is(":checked");
	chasm_save.cSkill8_6 = $("#cSkill8_6").is(":checked");

	chasm_save.cSkill9_1 = $("#cSkill9_1").is(":checked");
	chasm_save.cSkill9_2 = $("#cSkill9_2").is(":checked");
	chasm_save.cSkill9_3 = $("#cSkill9_3").is(":checked");
	chasm_save.cSkill9_4 = $("#cSkill9_4").is(":checked");
	chasm_save.cSkill9_5 = $("#cSkill9_5").is(":checked");
	chasm_save.cSkill9_6 = $("#cSkill9_6").is(":checked");

	chasm_save.cSkill10_1 = $("#cSkill10_1").is(":checked");
	chasm_save.cSkill10_2 = $("#cSkill10_2").is(":checked");
	chasm_save.cSkill10_3 = $("#cSkill10_3").is(":checked");
	chasm_save.cSkill10_4 = $("#cSkill10_4").is(":checked");
	chasm_save.cSkill10_5 = $("#cSkill10_5").is(":checked");
	chasm_save.cSkill10_6 = $("#cSkill10_6").is(":checked");

	chasm_save.nSkill0	= $("#nSkill0").html();
	chasm_save.nSkill1	= $("#nSkill1").html();
	chasm_save.nSkill2	= $("#nSkill2").html();
	chasm_save.nSkill3	= $("#nSkill3").html();
	chasm_save.nSkill4	= $("#nSkill4").html();
	chasm_save.nSkill5	= $("#nSkill5").html();
	chasm_save.nSkill6	= $("#nSkill6").html();
	chasm_save.nSkill7	= $("#nSkill7").html();
	chasm_save.nSkill8	= $("#nSkill8").html();
	chasm_save.nSkill9	= $("#nSkill9").html();
	chasm_save.nSkill10	= $("#nSkill10").html();
	chasm_save.nSkill11	= $("#nSkill11").html();
	chasm_save.nSkill12	= $("#nSkill12").html();
	chasm_save.nSkill13	= $("#nSkill13").html();
	chasm_save.nSkill14	= $("#nSkill14").html();
	chasm_save.nSkill15	= $("#nSkill15").html();
	chasm_save.nSkill16	= $("#nSkill16").html();
	chasm_save.nSkill17	= $("#nSkill17").html();
	chasm_save.nSkill18	= $("#nSkill18").html();

	chasm_save.nSkill0_rank		= $("#nSkill0_rank").html();
	chasm_save.nSkill1_rank		= $("#nSkill1_rank").html();
	chasm_save.nSkill2_rank		= $("#nSkill2_rank").html();
	chasm_save.nSkill3_rank		= $("#nSkill3_rank").html();
	chasm_save.nSkill4_rank		= $("#nSkill4_rank").html();
	chasm_save.nSkill5_rank		= $("#nSkill5_rank").html();
	chasm_save.nSkill6_rank		= $("#nSkill6_rank").html();
	chasm_save.nSkill7_rank		= $("#nSkill7_rank").html();
	chasm_save.nSkill8_rank		= $("#nSkill8_rank").html();
	chasm_save.nSkill9_rank		= $("#nSkill9_rank").html();
	chasm_save.nSkill10_rank	= $("#nSkill10_rank").html();
	chasm_save.nSkill11_rank	= $("#nSkill11_rank").html();
	chasm_save.nSkill12_rank	= $("#nSkill12_rank").html();
	chasm_save.nSkill13_rank	= $("#nSkill13_rank").html();
	chasm_save.nSkill14_rank	= $("#nSkill14_rank").html();
	chasm_save.nSkill15_rank	= $("#nSkill15_rank").html();
	chasm_save.nSkill16_rank	= $("#nSkill16_rank").html();
	chasm_save.nSkill17_rank	= $("#nSkill17_rank").html();
	chasm_save.nSkill18_rank	= $("#nSkill18_rank").html();

	chasm_save.nSkill0_1 = $("#nSkill0_1").is(":checked");
	chasm_save.nSkill0_2 = $("#nSkill0_2").is(":checked");
	chasm_save.nSkill0_3 = $("#nSkill0_3").is(":checked");
	chasm_save.nSkill0_4 = $("#nSkill0_4").is(":checked");
	chasm_save.nSkill0_5 = $("#nSkill0_5").is(":checked");
	chasm_save.nSkill0_6 = $("#nSkill0_6").is(":checked");

	chasm_save.nSkill1_1 = $("#nSkill1_1").is(":checked");
	chasm_save.nSkill1_2 = $("#nSkill1_2").is(":checked");
	chasm_save.nSkill1_3 = $("#nSkill1_3").is(":checked");
	chasm_save.nSkill1_4 = $("#nSkill1_4").is(":checked");
	chasm_save.nSkill1_5 = $("#nSkill1_5").is(":checked");
	chasm_save.nSkill1_6 = $("#nSkill1_6").is(":checked");

	chasm_save.nSkill2_1 = $("#nSkill2_1").is(":checked");
	chasm_save.nSkill2_2 = $("#nSkill2_2").is(":checked");
	chasm_save.nSkill2_3 = $("#nSkill2_3").is(":checked");
	chasm_save.nSkill2_4 = $("#nSkill2_4").is(":checked");
	chasm_save.nSkill2_5 = $("#nSkill2_5").is(":checked");
	chasm_save.nSkill2_6 = $("#nSkill2_6").is(":checked");

	chasm_save.nSkill3_1 = $("#nSkill3_1").is(":checked");
	chasm_save.nSkill3_2 = $("#nSkill3_2").is(":checked");
	chasm_save.nSkill3_3 = $("#nSkill3_3").is(":checked");
	chasm_save.nSkill3_4 = $("#nSkill3_4").is(":checked");
	chasm_save.nSkill3_5 = $("#nSkill3_5").is(":checked");
	chasm_save.nSkill3_6 = $("#nSkill3_6").is(":checked");

	chasm_save.nSkill4_1 = $("#nSkill4_1").is(":checked");
	chasm_save.nSkill4_2 = $("#nSkill4_2").is(":checked");
	chasm_save.nSkill4_3 = $("#nSkill4_3").is(":checked");
	chasm_save.nSkill4_4 = $("#nSkill4_4").is(":checked");
	chasm_save.nSkill4_5 = $("#nSkill4_5").is(":checked");
	chasm_save.nSkill4_6 = $("#nSkill4_6").is(":checked");

	chasm_save.nSkill5_1 = $("#nSkill5_1").is(":checked");
	chasm_save.nSkill5_2 = $("#nSkill5_2").is(":checked");
	chasm_save.nSkill5_3 = $("#nSkill5_3").is(":checked");
	chasm_save.nSkill5_4 = $("#nSkill5_4").is(":checked");
	chasm_save.nSkill5_5 = $("#nSkill5_5").is(":checked");
	chasm_save.nSkill5_6 = $("#nSkill5_6").is(":checked");

	chasm_save.nSkill6_1 = $("#nSkill6_1").is(":checked");
	chasm_save.nSkill6_2 = $("#nSkill6_2").is(":checked");
	chasm_save.nSkill6_3 = $("#nSkill6_3").is(":checked");
	chasm_save.nSkill6_4 = $("#nSkill6_4").is(":checked");
	chasm_save.nSkill6_5 = $("#nSkill6_5").is(":checked");
	chasm_save.nSkill6_6 = $("#nSkill6_6").is(":checked");

	chasm_save.nSkill7_1 = $("#nSkill7_1").is(":checked");
	chasm_save.nSkill7_2 = $("#nSkill7_2").is(":checked");
	chasm_save.nSkill7_3 = $("#nSkill7_3").is(":checked");
	chasm_save.nSkill7_4 = $("#nSkill7_4").is(":checked");
	chasm_save.nSkill7_5 = $("#nSkill7_5").is(":checked");
	chasm_save.nSkill7_6 = $("#nSkill7_6").is(":checked");

	chasm_save.nSkill8_1 = $("#nSkill8_1").is(":checked");
	chasm_save.nSkill8_2 = $("#nSkill8_2").is(":checked");
	chasm_save.nSkill8_3 = $("#nSkill8_3").is(":checked");
	chasm_save.nSkill8_4 = $("#nSkill8_4").is(":checked");
	chasm_save.nSkill8_5 = $("#nSkill8_5").is(":checked");
	chasm_save.nSkill8_6 = $("#nSkill8_6").is(":checked");

	chasm_save.nSkill9_1 = $("#nSkill9_1").is(":checked");
	chasm_save.nSkill9_2 = $("#nSkill9_2").is(":checked");
	chasm_save.nSkill9_3 = $("#nSkill9_3").is(":checked");
	chasm_save.nSkill9_4 = $("#nSkill9_4").is(":checked");
	chasm_save.nSkill9_5 = $("#nSkill9_5").is(":checked");
	chasm_save.nSkill9_6 = $("#nSkill9_6").is(":checked");

	chasm_save.nSkill10_1 = $("#nSkill10_1").is(":checked");
	chasm_save.nSkill10_2 = $("#nSkill10_2").is(":checked");
	chasm_save.nSkill10_3 = $("#nSkill10_3").is(":checked");
	chasm_save.nSkill10_4 = $("#nSkill10_4").is(":checked");
	chasm_save.nSkill10_5 = $("#nSkill10_5").is(":checked");
	chasm_save.nSkill10_6 = $("#nSkill10_6").is(":checked");

	chasm_save.nSkill11_1 = $("#nSkill11_1").is(":checked");
	chasm_save.nSkill11_2 = $("#nSkill11_2").is(":checked");
	chasm_save.nSkill11_3 = $("#nSkill11_3").is(":checked");
	chasm_save.nSkill11_4 = $("#nSkill11_4").is(":checked");
	chasm_save.nSkill11_5 = $("#nSkill11_5").is(":checked");
	chasm_save.nSkill11_6 = $("#nSkill11_6").is(":checked");

	chasm_save.nSkill12_1 = $("#nSkill12_1").is(":checked");
	chasm_save.nSkill12_2 = $("#nSkill12_2").is(":checked");
	chasm_save.nSkill12_3 = $("#nSkill12_3").is(":checked");
	chasm_save.nSkill12_4 = $("#nSkill12_4").is(":checked");
	chasm_save.nSkill12_5 = $("#nSkill12_5").is(":checked");
	chasm_save.nSkill12_6 = $("#nSkill12_6").is(":checked");

	chasm_save.nSkill13_1 = $("#nSkill13_1").is(":checked");
	chasm_save.nSkill13_2 = $("#nSkill13_2").is(":checked");
	chasm_save.nSkill13_3 = $("#nSkill13_3").is(":checked");
	chasm_save.nSkill13_4 = $("#nSkill13_4").is(":checked");
	chasm_save.nSkill13_5 = $("#nSkill13_5").is(":checked");
	chasm_save.nSkill13_6 = $("#nSkill13_6").is(":checked");

	chasm_save.nSkill14_1 = $("#nSkill14_1").is(":checked");
	chasm_save.nSkill14_2 = $("#nSkill14_2").is(":checked");
	chasm_save.nSkill14_3 = $("#nSkill14_3").is(":checked");
	chasm_save.nSkill14_4 = $("#nSkill14_4").is(":checked");
	chasm_save.nSkill14_5 = $("#nSkill14_5").is(":checked");
	chasm_save.nSkill14_6 = $("#nSkill14_6").is(":checked");

	chasm_save.nSkill15_1 = $("#nSkill15_1").is(":checked");
	chasm_save.nSkill15_2 = $("#nSkill15_2").is(":checked");
	chasm_save.nSkill15_3 = $("#nSkill15_3").is(":checked");
	chasm_save.nSkill15_4 = $("#nSkill15_4").is(":checked");
	chasm_save.nSkill15_5 = $("#nSkill15_5").is(":checked");
	chasm_save.nSkill15_6 = $("#nSkill15_6").is(":checked");

	chasm_save.nSkill16_1 = $("#nSkill16_1").is(":checked");
	chasm_save.nSkill16_2 = $("#nSkill16_2").is(":checked");
	chasm_save.nSkill16_3 = $("#nSkill16_3").is(":checked");
	chasm_save.nSkill16_4 = $("#nSkill16_4").is(":checked");
	chasm_save.nSkill16_5 = $("#nSkill16_5").is(":checked");
	chasm_save.nSkill16_6 = $("#nSkill16_6").is(":checked");

	chasm_save.nSkill17_1 = $("#nSkill17_1").is(":checked");
	chasm_save.nSkill17_2 = $("#nSkill17_2").is(":checked");
	chasm_save.nSkill17_3 = $("#nSkill17_3").is(":checked");
	chasm_save.nSkill17_4 = $("#nSkill17_4").is(":checked");
	chasm_save.nSkill17_5 = $("#nSkill17_5").is(":checked");
	chasm_save.nSkill17_6 = $("#nSkill17_6").is(":checked");

	chasm_save.nSkill18_1 = $("#nSkill18_1").is(":checked");
	chasm_save.nSkill18_2 = $("#nSkill18_2").is(":checked");
	chasm_save.nSkill18_3 = $("#nSkill18_3").is(":checked");
	chasm_save.nSkill18_4 = $("#nSkill18_4").is(":checked");
	chasm_save.nSkill18_5 = $("#nSkill18_5").is(":checked");
	chasm_save.nSkill18_6 = $("#nSkill18_6").is(":checked");

	chasm_save.wClarityLight1 = $("#wClarityLight1").is(":checked");
	chasm_save.wClarityLight2 = $("#wClarityLight2").is(":checked");
	chasm_save.wClarityLight3 = $("#wClarityLight3").is(":checked");
	chasm_save.wClarityLight4 = $("#wClarityLight4").is(":checked");

	chasm_save.wClaritySevere1 = $("#wClaritySevere1").is(":checked");
	chasm_save.wClaritySevere2 = $("#wClaritySevere2").is(":checked");
	chasm_save.wClaritySevere3 = $("#wClaritySevere3").is(":checked");
	chasm_save.wClaritySevere4 = $("#wClaritySevere4").is(":checked");

	chasm_save.wClarityCritical1 = $("#wClarityCritical1").is(":checked");
	chasm_save.wClarityCritical2 = $("#wClarityCritical2").is(":checked");

	chasm_save.wHealthLight1 = $("#wHealthLight1").is(":checked");
	chasm_save.wHealthLight2 = $("#wHealthLight2").is(":checked");
	chasm_save.wHealthLight3 = $("#wHealthLight3").is(":checked");
	chasm_save.wHealthLight4 = $("#wHealthLight4").is(":checked");

	chasm_save.wHealthSevere1 = $("#wHealthSevere1").is(":checked");
	chasm_save.wHealthSevere2 = $("#wHealthSevere2").is(":checked");
	chasm_save.wHealthSevere3 = $("#wHealthSevere3").is(":checked");
	chasm_save.wHealthSevere4 = $("#wHealthSevere4").is(":checked");

	chasm_save.wHealthCritical1 = $("#wHealthCritical1").is(":checked");
	chasm_save.wHealthCritical2 = $("#wHealthCritical2").is(":checked");

	chasm_save.wStressLight1 = $("#wStressLight1").is(":checked");
	chasm_save.wStressLight2 = $("#wStressLight2").is(":checked");
	chasm_save.wStressLight3 = $("#wStressLight3").is(":checked");
	chasm_save.wStressLight4 = $("#wStressLight4").is(":checked");

	chasm_save.wStressSevere1 = $("#wStressSevere1").is(":checked");
	chasm_save.wStressSevere2 = $("#wStressSevere2").is(":checked");
	chasm_save.wStressSevere3 = $("#wStressSevere3").is(":checked");
	chasm_save.wStressSevere4 = $("#wStressSevere4").is(":checked");

	chasm_save.wStressCritical1 = $("#wStressCritical1").is(":checked");
	chasm_save.wStressCritical2 = $("#wStressCritical2").is(":checked");
}

function storeSave() {
	// Generate Save
	generateSave();

	// Save to Local Storage
	lib_chasm_store_save(save_path, chasm_save);
}

function copySave() {
	// Generate Save
	generateSave();

	// Copy to Clipboard
	var textArea = document.createElement("textarea");
	textArea.value = JSON.stringify(chasm_save);
	// Avoid scrolling to bottom
	textArea.style.top = "0";
	textArea.style.left = "0";
	textArea.style.position = "fixed";
	document.body.appendChild(textArea);
	textArea.focus();
	textArea.select();
	try {
	  document.execCommand('copy');
	} catch (err) {
	  console.error('Copy failed ', err);
	}
	document.body.removeChild(textArea);
}

function autoSave() {
	//storeSave();
}

function clearSave() {
	if (confirm("Creating a new character will erase your current sheet. Consider exporting your character first.")) {
		lib_chasm_delete_save(save_path);
		loadSaveFromObject(new saveData());
		refreshUi();
	}
}

function downloadSave() {
	// Create an invisible A element
	var textArea = document.createElement("a");
	// Avoid scrolling to bottom
	textArea.style.top = "0";
	textArea.style.left = "0";
	textArea.style.position = "fixed";
	textArea.style.display = "none";

	textArea.href = 'data:attachment/text,' + encodeURI(JSON.stringify(chasm_save));
	let filename = $("#charName").html();
	filename = filename.replace(/\s/g, '');
	filename = filename.substring(0, 20);
	filename += ".txt";
	textArea.download = filename;

	document.body.appendChild(textArea);
	textArea.click();

	// Cleanup
	document.body.removeChild(textArea);
}

function importSave() {
	if (window.File && window.FileReader && window.FileList && window.Blob) {
		$("#fileinput").click();
	}
}

function importHandler() {
	if ($("#fileinput").val() != "") {
		let reader = new FileReader();
		let files = $("#fileinput").prop("files");
		reader.readAsText(files[0], 'UTF-8');
	
		reader.onload = function() {
			loadSaveFromObject(JSON.parse(this.result));
			refreshUi();
			storeSave();
		}
	}
}