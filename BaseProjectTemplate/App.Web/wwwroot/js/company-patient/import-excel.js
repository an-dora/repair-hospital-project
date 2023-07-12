
$(function () {
	bsCustomFileInput.init();
});

var isLoading = false;

$(".js-btn-import").click(function (ev) {
	var form = $(this).closest("form");

	if (form.valid()) {
		var file = $("#FileExcel")[0].files[0];
		var fileExt = file.name.split(".").pop();
		if (fileExt.toUpperCase() != "XLSX") {
			SnackBar.danger("Chỉ chấp nhận định dạng file .xlsx", 6000, 'top-center');
			return;
		}
		var formData = new FormData(form[0]);

		$.ajax({
			type: 'POST',
			url: "/CompanyPatient/ImportData",
			data: formData,
			processData: false,
			contentType: false,
			beforeSend: function (jqXHR, settings) {
				showLoading();
			},
			success: function (res) {
				if (res.success) {
					SnackBar.success(res.message, 30000, 'top-center');
				} else {
					SnackBar.danger(res.message, 40000, 'top-center');
				}
			},
			complete: function () {
				hideLoading();
			}
		});
	}
})