$(document).ready(function() {

    $('button').click(function(e) {
        var precoUnitario = document.querySelector(".precoProdutoModal").textContent.replace(",", ".");
        var button_classes, value = +$('.counter').val();
        button_classes = $(e.currentTarget).prop('class');

        if (button_classes.indexOf('up_count') !== -1) {
            value = (value) + 1;
            var subTotal = parseInt(value) * parseFloat(precoUnitario);
            var valornobotao = document.querySelector(".subTotalProdutoModal");
            valornobotao.textContent = subTotal.toFixed(2).toString().replace(".", ",");
        }

        if (button_classes.indexOf('down_count') !== -1) {
            value = (value) - 1;
            if (value == 0) { value = 1 }
            var subTotal = parseInt(value) * parseFloat(precoUnitario);
            var valornobotao = document.querySelector(".subTotalProdutoModal");
            valornobotao.textContent = subTotal.toFixed(2).toString().replace(".", ",");
        }

        $('.counter').val(value);
    });

    $('.counter').focusout(function() {
        var precoUnitario = document.querySelector(".precoProdutoModal").textContent.replace(",", ".");
        var value = +$('.counter').val();
        value = (value)
        var subTotal = parseInt(value) * parseFloat(precoUnitario);
        var valornobotao = document.querySelector(".subTotalProdutoModal");
        valornobotao.textContent = subTotal.toFixed(2).toString().replace(".", ",");
    });
});