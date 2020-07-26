(function () {
    $(function () {

        var _stateService = abp.services.app.state;
        var _$modal = $('#StateCreateModal');
        var _$form = _$modal.find('form');

        _$form.validate({
        });

        $('#RefreshButton').click(function () {
            refreshRoleList();
        });

        $('.delete-role').click(function () {
            var roleId = $(this).attr("data-role-id");
            var roleName = $(this).attr('data-role-name');

            deleteRole(roleId, roleName);
        });

        $('.edit-role').click(function (e) {
            var roleId = $(this).attr("data-role-id");

            e.preventDefault();
            abp.ajax({
                url: abp.appPath + 'Roles/EditRoleModal?roleId=' + roleId,
                type: 'POST',
                dataType: 'html',
                success: function (content) {
                    $('#RoleEditModal div.modal-content').html(content);
                },
                error: function (e) { }
            });
        });

        _$form.find('button[type="submit"]').click(function (e) {
            debugger
            e.preventDefault();

            if (!_$form.valid()) {
                return;
            }

            abp.ui.setBusy(_$modal);
           
            //_roleService.create(role).done(function () {
            //    _$modal.modal('hide');
            //    location.reload(true); //reload page to see new role!
            //}).always(function () {
            //    abp.ui.clearBusy(_$modal);
            //});
                        
            //var stateName = $("#statename").val();
            var state = _$form.serializeFormToObject();
            //var data0 = { Id: null, StateName: stateName };
            //var json = JSON.stringify(data0);
            _stateService.create(state).done(function () {
                _$modal.modal('hide');
                location.reload(true); //reload page to see new role!
            }).always(function () {
                abp.ui.clearBusy(_$modal);
            });
            //abp.ajax({
            //    url: abp.appPath + 'State/CreateOrEdit',
            //    type: 'POST',
            //    data: json,
            //    dataType: 'html',
            //    success: function (content) {
            //        _$modal.modal('hide');
            //        location.reload(true); //reload page to see new role!
            //    },
            //    error: function (e) { }
            //});
        });

        _$modal.on('shown.bs.modal', function () {
            _$modal.find('input:not([type=hidden]):first').focus();
        });

        function refreshRoleList() {
            location.reload(true); //reload page to see new role!
        }

        function deleteRole(roleId, roleName) {
            abp.message.confirm(
                "Remove Users from Role and delete Role '" + roleName + "'?",
                function (isConfirmed) {
                    if (isConfirmed) {
                        _roleService.delete({
                            id: roleId
                        }).done(function () {
                            refreshRoleList();
                        });
                    }
                }
            );
        }
    });
})();
