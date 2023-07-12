
const departmentTemplate = $("#department-tmpl").text();
const companyId = $("#Id").val();


$(function () {
	if (!companyId) {
		// Trang thêm mới
		// Tạo mặc định 1 dòng data cho phòng ban
		$(".js-department").append(departmentTemplate);
	}
});

// nút thêm phòng ban
$(document).on("click", ".js-department-add", function (e) {
	$(e.target).closest(".js-department-row").after(departmentTemplate);
});

// nút xóa phòng ban
$(document).on("click", ".js-department-del", function (e) {
	if ($(".js-department-row").length > 1) {
		$(e.target).closest(".js-department-row").remove();
	} else {
		Toast.danger("Công ty phải có thông tin phòng ban");
	}
});

// nút thêm phòng ban trang edit
$(document).on("click", ".js-department-edit-button", function (e) {
	$(e.target).closest("form").find(".js-department-row:last").after(departmentTemplate);
});

$("#js-btn-save").click(function (ev) {
	// collect data
	var data = {
		id: 0,
		name: $("#Name").val(),
		departments: []
	};

	var departments = Array.from($(".js-department-input"));
	data.departments = departments.map(function (item) {
		if ($(item).val() !== "") {
			return {
				id: 0,
				name: $(item).val()
			}
		}
	});

	if ($("form").valid()) {
		$.post("/Company/Create", data, function (res) {
			location.href = res;
		});
	}
});


$("#js-btn-save-edit").click(function (ev) {
	// collect data
	var data = {
		id: $("#Id").val(),
		name: $("#Name").val(),
		departments: []
	};

	var departments = Array.from($(".js-department-edit:not(:first)"));
	data.departments = departments.map(function (item) {
		let id = $(item).find(".js-department-id").val();
		let name = $(item).find(".js-department-input").val();
		let isHidden = $(item).find(".js-department-hidden").prop('checked');
		if (name !== "") {
			return {
				id: id,
				name: name,
				isHidden
			}
		}
	});

	if ($("form").valid()) {
		$.post("/Company/Edit", data, function (res) {
			location.href = res;
		});
	}
});