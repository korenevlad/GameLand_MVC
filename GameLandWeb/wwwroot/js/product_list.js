var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblDataProduct').DataTable({
        "ajax": { url: '/admin/product/getall' },
        "columns": [
            { data: 'name', "width": "20%" },
            { data: 'article', "width": "10%" },
            { data: 'price', "width": "10%" },
            { data: 'oldPrice', "width": "10%" },
            { data: 'category_of_product.name', "width": "15%" },
            {
                data: 'id',
                "render": function (data) {
                    return `<div class="w-75 btn-group" role="group">
                    <a href="/admin/product/upsert?id=${data}" class="btn btn-primary mx-2"><i class="bi bi-pencil-fill"></i > Обновить</a>
                    <a onClick=Delete('/admin/product/delete/${data}') class="btn btn-danger mx-2"><i class="bi bi-trash3"></i > Удалить</a>
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
        text: "Товар будет удален безвозвратно!",
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