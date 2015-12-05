var errPage = '<div class="info-box bg-yellow">\
                <span class="info-box-icon"><i class="ion ion-ios-information"></i></span>\
                <div class="info-box-content">\
                  <span class="info-box-text">ОШИБКА</span>\
                    <div class="progress">\
                    <div class="progress-bar" style="width: 100%"></div>\
                  </div>\
                  <span class="progress-description">\
                    В процессе получения ответа от сервера произошла ошибка\
                  </span>\
                </div><!-- /.info-box-content -->\
              </div>'
$('.actionhref').click(function () {
    var sel = this.id;
    var path = $(this).data('url');
    //$('#mPBar').show(100);
    var ucnavUrl = path;
    ProgressInAction('1');
    $.get(ucnavUrl, function (data) {
        $('#mainContainer').empty().html(data);
    }).success(function () {
        ProgressInAction('0');
    }).error(function () {
        $('#mainContainer').empty().html(errPage);
        ProgressInAction('0');
    })
})

$('.modalCont').click(function () {
    var path = $(this).data('ajaxpath');
    console.log(path);
    $('#ModMessages').modal({
        keyboard: false
    }, 'show');
})

function ProgressInAction(act) {

    if (act == '1') {
        $('#progCont').attr('hidden', false);
        $('#progBody').css('width', '50%');
    }
    else {
        $('#progBody').css('width', '100%');
        setTimeout(function () {
            $('#progCont').attr('hidden', true);
        }, 500);

    }
};


function ConvertDate(date) {
    var utcdate = {
        year: date.substr(6, 4),
        month: date.substr(3, 2),
        day: date.substr(0, 2)
    };
    return utcdate.year + '-' + utcdate.month + '-' + utcdate.day;
};

function ShowCurrentDate() {
    var dNow = new Date();
    var utcdate = {
        year: dNow.getFullYear(),
        month: (dNow.getMonth() + 1).toString().length > 1 ? (dNow.getMonth() + 1) : '0' + (dNow.getMonth() + 1),
        day: dNow.getDate().toString().length > 1 ? dNow.getDate() : '0' + dNow.getDate()
    };
    return utcdate.year + '-' + utcdate.month + '-' + utcdate.day;
}
