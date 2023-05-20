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
	//loadSave();

	// Loading finished, reveal the game
	$("#manager_box").css("display", "block")
}

// +----------------+
// | Task Callbacks |
// +----------------+

function animation_tick() {
}

// +-----------------+
// | Button Handling |
// +-----------------+

// +---------------+
// | UI Management |
// +---------------+

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

	constructor() {
		this.saveCount 		= 0;
	}
}

var chasm_save;
var chasm_incoming_save;
const save_path = "chasm";

function loadSave() {
	chasm_save = new saveData();
	chasm_incoming_save = lib_chasm_load_save(save_path);

	if (chasm_incoming_save) {
		// Merge Save
		lib_chasm_merge_save(chasm_save, chasm_incoming_save);

		// Load Game
		save_unpack_achievements(chasm_save.achievements);
		save_unpack_milestones(chasm_save.milestones);
		save_unpack_currency(chasm_save.currency);
		save_unpack_upgrades(chasm_save.upgrades);
		save_unpack_storage(chasm_save.storage);

		// Update UI elements
		refresh_ui();
	}
}

function storeSave() {
	chasm_save.saveCount++;
	chasm_save.achievements 	= save_pack_achievements();
	chasm_save.milestones 		= save_pack_milestones();
	chasm_save.currency 		= save_pack_currency();
	chasm_save.upgrades 		= save_pack_upgrades();
	chasm_save.storage			= save_pack_storage();

	// Save to Local Storage
	lib_chasm_store_save(save_path, chasm_save);
}

function autoSave() {
	//storeSave();
}

function clearSave() {
	lib_chasm_delete_save(save_path);
}

// Save data population
function save_pack_achievements() {
	var object = {};
	for (let i = aid.achievement_first; i < aid.achievement_count; i++) {
		object[chasm_achievements[i].name] = chasm_achievements[i].unlocked;
	}
	return object;
}

function save_unpack_achievements(object) {
	for (var prop in object) {
		chasm_achievements[aid[prop]].unlocked = object[prop];
	}
}

function save_pack_milestones() {
	var object = {};
	for (let i = mid.milestone_first; i < mid.milestone_count; i++) {
		object[chasm_milestones[i].name] = chasm_milestones[i].unlocked;
	}
	return object;
}

function save_unpack_milestones(object) {
	for (var prop in object) {
		chasm_milestones[mid[prop]].unlocked = object[prop];
	}
}

function save_pack_currency() {
	var object = {};
	for (let i = cid.currency_first; i < cid.currency_count; i++) {
		object[chasm_currency[i].resource.name] = lib_chasm_pack_resource(chasm_currency[i].resource);
	}
	return object;
}

function save_unpack_currency(object) {
	for (var prop in object) {
		chasm_currency[cid[prop]].resource = lib_chasm_unpack_resource(prop, object[prop]);
	}
}

function save_pack_upgrades() {
	var object = {};
	for (let i = uid.upgrade_first; i < uid.upgrade_count; i++) {
		object[chasm_upgrades[i].name] = chasm_upgrades[i].unlocked;
	}
	return object;
}

function save_unpack_upgrades(object) {
	for (var prop in object) {
		chasm_upgrades[uid[prop]].unlocked = object[prop];
	}
}

function save_pack_storage() {
	var object = {};
	for (let i = sid.storage_first; i < sid.storage_count; i++) {
		object[chasm_storage[i].name] = {};
		object[chasm_storage[i].name].workers_gather 	= chasm_storage[i].workers_gather;
		object[chasm_storage[i].name].workers_drop 		= chasm_storage[i].workers_drop;
		object[chasm_storage[i].name].workers_survey	= chasm_storage[i].workers_survey;
		object[chasm_storage[i].name].machinery_1		= chasm_storage[i].machinery_1;
		object[chasm_storage[i].name].gather_progress	= chasm_storage[i].gather_progress;
		object[chasm_storage[i].name].drop_progress		= chasm_storage[i].drop_progress;
	}
	return object;
}

function save_unpack_storage(object) {
	for (var storage in object) {
		chasm_storage[sid[storage]].workers_gather 		= object[storage].workers_gather;
		chasm_storage[sid[storage]].workers_drop 		= object[storage].workers_drop;
		chasm_storage[sid[storage]].workers_survey 		= object[storage].workers_survey;
		chasm_storage[sid[storage]].machinery_1			= object[storage].machinery_1;
		chasm_storage[sid[storage]].gather_progress 	= object[storage].gather_progress;
		chasm_storage[sid[storage]].drop_progress 		= object[storage].drop_progress;
	}
}