$(document).ready(function () {
	$(".Add-new-renew").on("click", function () {
		var btn = $(this);

		bootbox.confirm({
			message: 'Do you want to add new Subscription?',
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
					$.get({
						url: "/Subscribers/Renew?subscriberId=" + btn.data('id'),
						success: function () {
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