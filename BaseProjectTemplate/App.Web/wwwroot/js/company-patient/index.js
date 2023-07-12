
window.printTempl = '';

$(function () {
	window.printTempl = $("#print-template").text();

	// Cache template
	mustache.parse(printTempl);
});

$(".js-year-only").change(function (ev) {
	var formGr = $(this).closest(".form-group");
	formGr.find("#DoB").toggleClass("fake-d-none");
	formGr.find("#YoB").toggleClass("fake-d-none");
	if (this.checked) {
		formGr.find("#DoB").val('');
	} else {
		formGr.find("#YoB").val('');
	}
});

// Chức năng in phiếu khám
$(".js-print-health-cert").click(function (ev) {
	ev.preventDefault();
	var id = $(this).closest("tr").data("id");
	let url = $(this).attr("href");
	var printAndUpdate = function () {
		window.print();
		$.post(`/CompanyPatient/UpdateExamDate?patientId=${id}`);
	}
	showLoading();
	$.getJSON(url, function (res) {
		res.fullName = res.fullName.toUpperCase();
		res.identityDoI = convertToDMY(res.identityDoI);
		var printArea = $("#print-area");
		var rendered = mustache.render(window.printTempl, res);
		printArea.html(rendered);
	}).then(function (res) {
		hideLoading();
		if (res.printCount < 1) {
			printAndUpdate();
		}

		var todayYMD = convertToYMD(new Date());
		var examDateYMD = convertToYMD(res.examDate);
		if (res.printCount >= 1) {
			// Nếu in phiếu nhiều lần nhưng thời gian lần này khác lần trước thì cần xác nhận
			if (todayYMD != examDateYMD) {
				confirm("Hệ thống ghi nhận người này đã được in phiếu trước đó, xác nhận in lại phiếu và cập nhật ngày khám thành hôm nay?", function () {
					printAndUpdate();
				});
			} else {
			// Nếu không thì không cần xác nhận
				printAndUpdate();
			}
		}
	});
});

$(".js-search-company").change(function () {
	var id = $(this).children(":selected").val();
	if (id === "") {
		$('.js-select-search-department').val('');
	}
	var opts = $('.js-select-search-department option:not(.d-none-value)');
	opts.each((index, item) => {
		if ($(item).attr('data-company-id') == id) {
			$('.js-select-search-department').val('');
			$(item).removeClass('d-none');
		} else {
			$(item).addClass('d-none');
		}
	});
});

$("#modalAddPatient .js-select-add-company").change(function () {
	var id = $(this).children(":selected").val();
	if (id === "") {
		$('#modalAddPatient .js-select-add-department').val('');
	}
	var opts = $('#modalAddPatient .js-select-add-department option:not(.d-none-value-add)');
	opts.each((index, item) => {
		if ($(item).attr('data-company-id') == id) {
			$('#modalAddPatient .js-select-add-department').val('');
			$(item).removeClass('d-none');
		} else {
			$(item).addClass('d-none');
		}
	});
});

$("#modal-EditPatient .js-select-add-company").change(function () {
	var id = $(this).children(":selected").val();
	if (id === "") {
		$('#modal-EditPatient .js-select-add-department').val('');
	}
	var opts = $('#modal-EditPatient .js-select-add-department option:not(.d-none-value-add)');
	opts.each((index, item) => {
		if ($(item).attr('data-company-id') == id) {
			$('#modal-EditPatient .js-select-add-department').val('');
			$(item).removeClass('d-none');
		} else {
			$(item).addClass('d-none');
		}
	});
});

// Chức năng sửa thông tin người khám
// Load thông tin và hiển thị lên modal
$(".js-edit-patient").click(function (ev) {
	ev.preventDefault();

	var modal = new Modal("EditPatient");
	var url = $(this).attr("data-url");
	showLoading();
	$.getJSON(url, function (res) {
		// Chỉnh sửa thông tin param
		res.gender = res.gender == 0 ? 'MALE' : 'FEMALE';
		var yearOnly = modal.modalBody.find(".js-year-only");
		// Logic nhập năm
		if (res.yoB && !yearOnly.is(":checked")) {
			yearOnly.prop('checked', true).change();
		} else if (!res.yoB && yearOnly.is(":checked")) {
			yearOnly.prop('checked', false).change();
		}
		// Sửa action của form
		$(this).closest("form").attr("action", this.href);
		// Tự điền vào form
		fillForm(res, ['age', 'reason', 'companyId', 'departmentId'], `#${modal.name}`);
		// Điền companyId và departmentId vào form
		$(`#modal-EditPatient .js-select-add-company option[value=${res.companyId}]`).attr('selected', true);
		var opts = $(`#modal-EditPatient .js-select-add-department option:not(.d-none-value-add)`);
		opts.each((index, item) => {
			if ($(item).attr('data-company-id') == res.companyId) {
				$('#modal-EditPatient .js-select-add-department').val('');
				$(item).removeClass('d-none');
			} else {
				$(item).addClass('d-none');
			}
		});
		if (res.departmentId) {
			$('#modal-EditPatient .js-select-add-department').val(res.departmentId);
		} else {
			$('#modal-EditPatient .js-select-add-department').val('');
		}
	}).then(function (ev) {
		// Ẩn loading và hiện modal
		hideLoading();
		modal.show();
	});
});

// Chức năng nhập kết quả khám bệnh
// Load thông tin và hiển thị lên modal
$(".js-input-result").click(function (ev) {
	ev.preventDefault();

	var modal = new Modal("InputPatientHistory");
	var url = $(this).attr("data-url");
	showLoading();
	$.getJSON(url, function (res) {
		if (res == null) {
			return;
		}
		modal.modalTitle.find('span').text(res.patientName);
		// Sửa action của form
		$(this).closest("form").attr("action", this.href);

		// Dùng ngày hiện tại nếu chưa có ngày
		if (!res.examDate) {
			res.examDate = new Date();
		}
		// Tự điền vào form
		fillForm(res, ['internalMedicine', 'externalMedicine', 'test'], `#${modal.name}`);
	}).then(function (res) {
		if (res == null) {
			hideLoading();
			SnackBar.danger("Người này đã có kết quả khám, không thể thêm mới", 30000, 'top-center');
			return;
		}
		// Ẩn loading và hiện modal
		hideLoading();
		modal.show();
	});
});
// Sự kiện submit dữ liệu khám - nhập lần đầu
$(".js-submit-input-history").click(function (ev) {
	ev.preventDefault();
	var form = $(this).closest("form"); 
	if (!form.valid()) return;

	var url = form.attr("action");
	var data = form.serialize();
	var pId = form.find("#CompanyPatientId").val();

	$.ajax({
		type: 'POST',
		url: url,
		data: data,
		success: function (res) {
			if (res.success) {
				// Hiện icon
				$(`tr[data-id=${pId}]`).find(".toggle-chk").prop("checked", true);
				// Cập nhật param trong url ajax
				var eleUpdate = $(`tr[data-id=${pId}]`).find(".js-update-result");
				var ajaxUrl = eleUpdate.attr("data-url");
				ajaxUrl = ajaxUrl.replace("IsDone=False", "IsDone=True");
				eleUpdate.attr("data-url", ajaxUrl);

				Toast.success(res.message);
			} else {
				SnackBar.danger(res.message, 10000, 'top-center');
			}
		},
		error: function (err) {
			SnackBar.danger("Đã xảy ra lỗi trong quá trình xử lý dữ liệu." + err);
		},
		complete: function () {
			var m = new Modal("InputPatientHistory");
			m.hide();
		}
	});
});

// Chức năng sửa kết quả khám bệnh
// Load thông tin và hiển thị lên modal
$(".js-update-result").click(function (ev) {
	ev.preventDefault();

	var modal = new Modal("UpdatePatientHistory");
	var url = $(this).attr("data-url");
	showLoading();
	$.getJSON(url, function (res) {
		if (res == null) {
			return;
		}
		modal.modalTitle.find('span').text(res.patientName);
		// Sửa action của form
		$(this).closest("form").attr("action", this.href);
		// Tự điền vào form
		fillForm(res, [], `#${modal.name}`);
	}).then(function (res) {
		if (res == null) {
			hideLoading();
			SnackBar.danger("Người này chưa có kết quả khám, vui lòng thêm kết quả khám", 30000, 'top-center');
			return;
		}
		// Ẩn loading và hiện modal
		hideLoading();
		modal.show();
	});
});
// Sự kiện submit dữ liệu khám - cập nhật
$(".js-submit-update-history").click(function (ev) {
	var form = $(this).closest("form");
	if (!form.valid()) return;

	var url = form.attr("action");
	var data = form.serialize();
	$.ajax({
		type: 'POST',
		url: url,
		data: data,
		success: function (res) {
			if (res.success) {
				Toast.success(res.message);
			} else {
				SnackBar.danger(res.message, 10000, 'top-center');
			}
		},
		error: function (err) {
			SnackBar.danger("Đã xảy ra lỗi trong quá trình xử lý dữ liệu." + err);
		},
		complete: function () {
			var m = new Modal("UpdatePatientHistory");
			m.hide();
		}
	});
});

// Load thông tin khám và hiển thị lên modal
$(".js-view-result").click(function (ev) {
	ev.preventDefault();

	var modal = new Modal("ListPatientHistory");
	modal.useFullScreenSize();
	var url = $(this).attr("href");
	showLoading();
	$.getJSON(url, function (res) {
		if (res == null) {
			return null;
		}
		console.log(res);
		modal.modalTitle.find('span').text(res.fullName);
		modal.modalBody.find('tbody').html('');
		var listRow = res.patientHistories.map((item) => {
			return `<tr class='${item.isDone ? "table-light" : ""}'>
						<td>${res.patientHistories.length--}</td>
						<td>${item.examDate != null ? convertToDMY(item.examDate) : ""}</td>
						<td>${item.height != null ? item.height : ""}</td>
						<td>${item.weigth != null ? item.weigth : ""}</td>
						<td>${item.bloodPressure != null ? item.bloodPressure : ""}</td>
						<td>${item.internalMedicine != null ? item.internalMedicine : ""}</td>
						<td>${item.externalMedicine != null ? item.externalMedicine : ""}</td>
						<td>${item.ophthalmology != null ? item.ophthalmology : ""}</td>
						<td>${item.otorhinolaryngology != null ? item.otorhinolaryngology : ""}</td>
						<td>${item.dentomaxillofacial != null ? item.dentomaxillofacial : ""}</td>
						<td>${item.test != null ? item.test : ""}</td>
						<td>${item.classification != null ? item.classification : ""}</td>
						<td>${item.reason != null ? item.reason : ""}</td>
					</tr>`;
		});
		modal.modalBody.find('tbody').html(listRow.join(''));
	}).then(function (res) {
		hideLoading();
		if (res == null) {
			SnackBar.danger("Không tìm thấy kết quả khám của người này, vui lòng nhập thông tin khám", 30000, 'top-center');
			return;
		}
		// Hiện modal khi có data
		modal.show();
	});
});

// chức năng export data
$('.js-export-data').click(function (ev) {
	ev.preventDefault();
	var url = $(this).attr('href');
	var data = $('.form-search').serialize();

	if ($("#CompanySearchId").val() == '') {
		SnackBar.danger('Hãy chọn 1 công ty để xuất file', 10000, 'top-center');
		return;
	}

	$.ajax({
		type: 'GET',
		url,
		data,
		xhrFields: {
			responseType: 'blob' // Đặt kiểu phản hồi thành 'blob' để nhận dữ liệu dạng Blob
		},
		beforeSend: function (jqXHR, settings) {
			showLoading();
		},
		success: function (res) {
			var blob = new Blob([res], { type: 'application/vnd.openxmlformats-officedocument.spreadsheetml.sheet' });

			// Tạo một đường link ảo
			var downloadLink = document.createElement('a');
			downloadLink.href = URL.createObjectURL(blob);
			downloadLink.download = `export_phongkham274_${Date.now()}.xlsx`; // Đặt tên tệp tùy chỉnh
			downloadLink.target = '_blank'; // Mở tệp trong một cửa sổ/tab mới

			// Kích hoạt sự kiện click để tải xuống
			downloadLink.click();

			// Giải phóng URL và đối tượng tải xuống
			URL.revokeObjectURL(downloadLink.href);
			downloadLink.remove();
		},
		error: function (res) {
			SnackBar.danger('Đã xảy ra lỗi trong quá trình xử lý dữ liệu', 10000, 'top-center');
		},
		complete: function () {
			hideLoading();
		}
	});
});