var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblDataCategory').DataTable({
        "ajax": { url: '/admin/category/getall' },
        "columns": [
            { data: 'name', "width": "25%" },
            { data: 'code', "width": "20%" },
            { data: 'description', "width": "25%" },
            {
                data: 'id',
                "render": function (data) {
                    return `<div class="w-75 btn-group" role="group">
                    <a href="/admin/category/upsert?id=${data}" class="btn btn-primary mx-2"><i class="bi bi-pencil-fill"></i > Обновить</a>
                    <a onClick=Delete('/admin/category/delete/${data}') class="btn btn-danger mx-2"><i class="bi bi-trash3"></i > Удалить</a>
                    </div>`
                },
                "width": "30%"
            }
        ]
    });
}




function Delete(url) {
    const swalWithBootstrapButtons = Swal.mixin({
        customClass: {
            confirmButton: 'btn btn-success',
            cancelButton: 'btn btn-danger'
        },
        buttonsStyling: false
    })

    swalWithBootstrapButtons.fire({
        title: 'Вы уверены?',
        text: "Категория будет удалена безвозвратно!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonText: 'Удалить',
        cancelButtonText: 'Отмена',
        reverseButtons: true
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'DELETE',
                success: function (data) {
                    dataTable.ajax.reload();
                    toastr.success(data.message);
                }
            })
        }
    })

}