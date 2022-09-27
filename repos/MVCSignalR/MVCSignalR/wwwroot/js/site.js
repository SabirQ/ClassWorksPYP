// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(() => {
    let connection = new signalR.HubConnectionBuilder().withUrl("/SignalServer").build();
    connection.start();
    connection.on("refreshEmployee", function () {
        loadProducts();
    })

    loadProducts();

    function loadProducts() {
        var tr = '';

        $.ajax({
            url: '/Home/Product',
            method: 'GET',
            success: (result) => {
                $.each(resukt, (key, value) => {
                    tr = tr + '<tr>< td > ${ value.id }</td >< td > ${value.ProductName}</td>< td > ${ value.Description }</td>  < td > ${ value.UnitsInStock }</td> < td > ${ value.UnitPrice }</td></tr>';
                })
                $('#products').html(tr);
            },
            error: (result) => {
                console.log(result);
            }
        })
    }

});