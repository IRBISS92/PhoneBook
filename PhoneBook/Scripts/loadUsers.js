function loadUsers() {
    $.ajax({
        type: 'POST',
        url: '/Account/LoadUsersFromRandomuser',
        beforeSend: function () {
            $("#loader").show();
            $("#shadow").show();
        },
        complete: function () {
            $("#loader").hide();
            $("#shadow").hide();
        }
    })
        .done(function (response) {
            $("#gridContainer").dxDataGrid("instance")
                .getDataSource()
                .reload();
        });
}