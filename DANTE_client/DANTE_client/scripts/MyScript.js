$(document).ready(function () {

    $('#btn_Clear').click(function () {
        //alert('clear');
        $('.controls').each(function () {
            var that = $(this);
            if (that.is('select'))
                that.val(0);
            else if (that.is('input'))
                that.val("");            
        });
    });
    $('#btn_FetchData').click(function () {
        $('#pnl_api_result .panel-body').addClass('loading');
       // $('#tbl_Result').show();

    });

});