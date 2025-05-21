// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    $('#table-Login').DataTable({
        "ordering": true,
        "paging": true,
        "searching": true,
        "oLanguage": {
            "sEmptyTable": "Nenhum registro encontrado na tabela",
            "sInfo": "Mostrar _START_ at&eacute;  _END_ de _TOTAL_ registros",
            "sInfoEmpty": "Mostar 0 at&eacute; 0 de 0 registros",
            "sInfoFiltered": "(filtrar de _MAX_ total registros)",
            "sInfoPostFix": "",
            "sInfoThousands": ".",
            "sLengthMenu": "Mostrar _MENU_ registros por pagina",
            "sLoadingRecords": "Carregando...",
            "sProcessing": "Processando...",
            "sZeroRecords": "Nenhum registro encontrado",
            "sSearch": "Pesquisar",
            "oPaginate": {
                "sNext": "Proximo",
                "sPrevious": "Anterior",
                "sFirst": "Primeiro",
                "sLast": "Ultimo"
            },

            "oAria": {
                "sSortAscending": "ordenar colunas de forma ascendente",
                "sSortDescending": "ordenanr colunar de forma descendente"
            }

        }

    });
})

$('.close-alert').click(function () {
    $("alert").hide('hide');
});
