$(document).ready(function () {
    $('#Domain').change(changeSelectedDomain);
});

function changeSelectedDomain() {
    $('#SelectedDomain').val($('#Domain option:selected').text());
}