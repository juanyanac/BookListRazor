﻿var dataTable;

$(document).ready(function () {
    loadDataTable();
})

function loadDataTable() {
    dataTable = $('#DT_load').dataTable({
        "ajax": {
            "url": "api/Book",
            "type": "GET",
            "dataTtype":"json"
        },
        "columns": [
            { "data": "name", "width": "20%" },
            { "data": "author", "width": "20%" },
            { "data": "isbn", "width": "20%" },
            {
                "data": "id",
                "render": function (data) {
                    return `<div class="text-center">
                                <a href="/BookList/Edit?id=${data}" class="btn btn-success" style='cursor:pointer; width:100px;'>Edit</a>
                                <a class="btn btn-danger text-white" style='cursor:pointer; width:100px;'>Delete</a>
                            </div>`;
                }, "width":"40%"
            }
        ],
        "language": {
            "emptyTable":"no data found"
        },
        "width":"100%"
    });
}