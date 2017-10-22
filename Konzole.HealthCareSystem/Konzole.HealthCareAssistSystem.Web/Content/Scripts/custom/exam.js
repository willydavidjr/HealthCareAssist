$(window).load(function () {


    StartTime();


 
    
});




function StartTime() {
    var CrawlerCount = 25;
    var seconds = getSecondDiff();
    var totalTimeSeconds = getTotalTimeSecondDiff();
    var isRemoved = false;
    var TransactionTime = setInterval(function () {
        seconds++;
        totalTimeSeconds++;
        var second = pad(seconds % 60);
        var minute = pad(parseInt((seconds % 3600) / 60, 10));
        var hour = pad(parseInt(seconds / 3600, 10));

        var tsecond = pad(totalTimeSeconds % 60);
        var tminute = pad(parseInt((totalTimeSeconds % 3600) / 60, 10));
        var thour = pad(parseInt(totalTimeSeconds / 3600, 10));



        $("#lblTime").html(hour + ":" + minute + ":" + second);

    }, 1000);
};

function pad(val) { return val > 9 ? val : "0" + val; }

function getHours(seconds) {
    return Math.floor(seconds / 3600);
}
function getMininutes(seconds) {
    return Math.floor((seconds % 3600) / 60);
}
function getSeconds(seconds) {
    return Math.floor(seconds % 60);
}


function getSecondDiff() {
    var start_actual_time = $("#TimeStart").val();
    var end_actual_time = $("#TimeEnd").val();
    start_actual_time = new Date(start_actual_time);
    end_actual_time = new Date(end_actual_time);

    var diff = end_actual_time - start_actual_time;

    return diff / 1000;
}

function getTotalTimeSecondDiff() {
    var start_actual_time = $("#FirstTimeStart").val();
    var end_actual_time = $("#TimeEnd").val();
    start_actual_time = new Date(start_actual_time);
    end_actual_time = new Date(end_actual_time);

    var diff = end_actual_time - start_actual_time;

    return diff / 1000;
}