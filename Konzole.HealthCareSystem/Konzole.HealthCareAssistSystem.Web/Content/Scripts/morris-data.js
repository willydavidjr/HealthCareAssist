$(function() {

    Morris.Bar({
        element: 'morris-bar-chart',
        data: [{
            y: 'Mon',
            a: 90.1,
            b: 9.9
        }, {
            y: 'Tue',
            a: 75,
            b: 25
        }, {
            y: 'Wed',
            a: 60,
            b: 40
        }, {
            y: 'Thu',
            a: 75,
            b: 25
        }, {
            y: 'Fri',
            a: 50,
            b: 50
        }, {
            y: 'Sat',
            a: 65,
            b: 35
        }],
        xkey: 'y',
        ykeys: ['a', 'b'],
        xLabelAngle: 35,
        ymax: 100,
        labels: ['Productive', 'NonProductive'],
        hideHover: 'auto'
    });

});
