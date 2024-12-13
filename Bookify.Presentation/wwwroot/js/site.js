function ApplyDataTables(){
    //$("table").dataTable({
    //    dom: 'Bfrtip',
    //    buttons: ['copy', 'csv', 'excel','pdf','print']
    //});

    $('table').DataTable();
};

function ApplySelect2() {
	$(".js-select2").select2();
}
function ApplyflatPickr() {
	$(".js-flatpickr").flatpickr();
}

/*
 link that has on packages that need it buttons to work  buttons: ['copy', 'csv', 'excel','pdf','print']

 https://datatables.net/extensions/buttons/examples/initialisation/topLevel.html
*/

$(document).ready(function () {
	$(".js-toggle-status").on("click", function () {
		var btn = $(this);

		bootbox.confirm({
			message: 'this is a confirm box with delete button! are you sure that?',
			buttons: {
				confirm: {
					label: 'yes',
					classname: 'btn-danger'
				},
				cancel: {
					label: 'no',
					classname: 'btn-secondary'
				}
			},
			callback: function (result) {
				if (result) {
					$.post({
						//url: "/Categories/Delete/" + btn.data('id'),
						url: btn.data('url'),
						data: {
							"__requestverificationtoken": $('input[name="__requestverificationtoken"]').val()
						},
						success: function () {
							var row = btn.parents('tr');
							var status = row.find('.js-status');

							if (status !== null) {
								var newstatus = status.text().toLowerCase().trim() === 'deleted' ? 'available' : 'deleted';
								status.text(newstatus).toggleClass('bg-success bg-danger');
							}

							row.addClass("animate__animated  animate__flash"); // add animate class from animate css website
							// if you want to use toastr package
							//toastr.success("category toggled successfully");

							// if you want to use sweetalert2 package

							swal.fire({
								title: 'success!',
								icon: 'success',
								text: 'saved successfully!'
							})
						},
						error: function () {
							swal.fire({
								title: 'error!',
								icon: 'error',
								text: 'error happens!'
							})
						}
					});
				}
			}
		});


	})

})

function SweetAlertMessage(message) {
	if (message) {
		swal.fire({
			title: 'success!',
			icon: 'success',
			text: message
		})
	}
}