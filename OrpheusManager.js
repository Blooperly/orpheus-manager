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

// +---------------+
// | UI Management |
// +---------------+

// Refresh UI
function refreshUi() {
	displayDerivedAttr();
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

function displayDerivedAttr() {
	let per = parseNumerals($("#attrPer").html());
	let foc = parseNumerals($("#attrFoc").html());
	let dex = parseNumerals($("#attrDex").html());
	let vit = parseNumerals($("#attrVit").html());
	let cha = parseNumerals($("#attrCha").html());
	let wil = parseNumerals($("#attrWil").html());

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
		$("#derVigilance").html(Math.floor(""));
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

	constructor() {
		this.saveCount = 0;

		this.attrPer = "";
		this.attrFoc = "";
		this.attrDex = "";
		this.attrVit = "";
		this.attrCha = "";
		this.attrWil = "";
	}
}

var chasm_save;
var chasm_incoming_save;
const save_path = "orpheus";

function loadSave() {
	chasm_save = new saveData();
	chasm_incoming_save = lib_chasm_load_save(save_path);

	if (chasm_incoming_save) {
		// Merge Save
		lib_chasm_merge_save(chasm_save, chasm_incoming_save);

		// Load Game
		$("#attrPer").html(chasm_save.attrPer);
		$("#attrFoc").html(chasm_save.attrFoc);
		$("#attrDex").html(chasm_save.attrDex);
		$("#attrVit").html(chasm_save.attrVit);
		$("#attrCha").html(chasm_save.attrCha);
		$("#attrWil").html(chasm_save.attrWil);
	}
}

function storeSave() {
	chasm_save.saveCount++;
	chasm_save.attrPer 	= $("#attrPer").html();
	chasm_save.attrFoc 	= $("#attrFoc").html();
	chasm_save.attrDex 	= $("#attrDex").html();
	chasm_save.attrVit 	= $("#attrVit").html();
	chasm_save.attrCha 	= $("#attrCha").html();
	chasm_save.attrWil 	= $("#attrWil").html();

	// Save to Local Storage
	lib_chasm_store_save(save_path, chasm_save);
}

function autoSave() {
	//storeSave();
}

function clearSave() {
	lib_chasm_delete_save(save_path);
}