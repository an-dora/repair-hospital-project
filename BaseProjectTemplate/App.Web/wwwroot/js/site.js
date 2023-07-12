$(function () {
	// tinnq
	// Tự động ẩn cảnh báo sau 10 giây
	$(".alert.js-alert").delay(10000).slideUp(300, function () {
		$(this).alert('close');
	});

	// Khởi tạo tooltip
	$(".js-tooltip").tooltip();

	$(".bs-autocomplete").bsautocomplete();
});

function convertToDMY(date, splitChar = '/') {
	if (!date) {
		return null;
	}
	if (typeof (date) == 'string') {
		date = new Date(date);
	}
	const yyyy = date.getFullYear();
	let mm = date.getMonth() + 1; // Months start at 0!
	let dd = date.getDate();

	if (dd < 10) dd = '0' + dd;
	if (mm < 10) mm = '0' + mm;

	return dd + splitChar + mm + splitChar + yyyy;
}

function convertToYMD(date, splitChar = '/') {
	if (!date) {
		return null;
	}
	if (typeof (date) == 'string') {
		date = new Date(date);
	}
	const yyyy = date.getFullYear();
	let mm = date.getMonth() + 1; // Months start at 0!
	let dd = date.getDate();

	if (dd < 10) dd = '0' + dd;
	if (mm < 10) mm = '0' + mm;

	return yyyy + splitChar + mm + splitChar + dd;
}

$(document).on("click", ".js-delete-confirm", function (ev) {
	ev.preventDefault();
	let btnDelete = $(this);
	let msg = btnDelete.data('msg');
	let mode = btnDelete.data('mode');
	if (!msg) {
		msg = 'Xác nhận xóa?';
	}

	confirm(msg, () => {
		if (mode == "submit") {
			let form = btnDelete.closest("form");
			if (form.valid()) {
				form.submit();
			}
		}
		else {
			location.href = $(this).attr("href");
		}
	});
});

function showLoading() {
	$("#loading").removeClass("d-none");
	$("#wrapper").addClass("app-loading");
}

function hideLoading() {
	setTimeout(function () {
		$("#loading").addClass("d-none");
		$("#wrapper").removeClass("app-loading");
	}, 250);
}

function fillForm(obj, excludeProps = [], parentSelector = null) {
	for (let key in obj) {
		if (excludeProps.indexOf(key) >= 0) {
			continue;
		}
		let eleId = key.charAt(0).toUpperCase() + key.slice(1);
		let eleInput;
		if (parentSelector) {
			eleInput = $(`${parentSelector} [name=${eleId}]`);
		} else {
			eleInput = $(`[name=${eleId}]`);
		}

		if (eleInput.length == 0) continue;

		let eleName = eleInput[0].nodeName;
		let value = obj[key];
		if (eleName == "INPUT") {
			let inputType = eleInput.attr("type");
			switch (inputType) {
				case "date": {
					value = convertToYMD(value, '-');
					eleInput.val(value);
					break;
				}
				case 'radio':
				case 'checkbox': {
					for (let i = 0; i < eleInput.length; i++) {
						let rad = $(eleInput[i]);
						if (rad.val() == value) {
							rad.prop('checked', true);
						}
					}
					break;
				}
				default: {
					eleInput.val(value);
					break;
				}
			}
		} else if (eleName == 'SELECT') {
			eleInput.val(value).change();
		} else if (eleName == 'TEXTAREA') {
			eleInput.val(value);
		}
	}
}