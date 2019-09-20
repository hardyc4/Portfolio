$('#target').click(function(e) {
    $('<div />').addClass('bullet-hole').css({
        top: e.offsetY - 5,
        left: e.offsetX - 5
    }).appendTo('#target');
    setTimeout(removeBulletHole, 5000);
});

function removeBulletHole() {
	$('#target .bullet-hole:not(:animated):first').fadeOut(function() {
    	$(this).remove();
    });
}