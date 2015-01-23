(function($){

    var score = 0,
    secondes = 50;
    function timer(){
        $('#countdown').html(secondes);
        secondes--;

        if(secondes<0){
            secondes = 0;
            $('#countdown').html('0');
            swal({
              title: 'End Of game',
              text: 'You have ' + score + ' points.',
              type: 'success',
              showCancelButton: true,
              confirmButtonText: 'Play again !',
              closeOnConfirm: true
            },
            function(){
              secondes = 50;   
              score = 0;
              $('#score span').html(score);
              $('.letter').remove();
              setTimeout(timer, 1000);
              setTimeout(generateLetters, 1000);
            });
        }else{
            setTimeout(timer, 1000);
            setTimeout(generateLetters, 1000);
        }

    }

    timer();
    generateLetters();

    $('body').on('keydown', function(e){
        if(secondes!=0){
             e.preventDefault();
             if(e.keyCode < 62){
                console.log('This key is disable');
             }else{
                var keycode = String.fromCharCode(e.keyCode).toLowerCase();
                $('.letter'+keycode).animate({ 'top'  : '20px', 'opacity': 0 }, 'fast');
                $('.letter'+keycode).fadeOut('slow').hide('slow', function() {
                    score += 5;
                    $('#score span').html(score);
                    $(this).remove();
                });
            }
        }
    });

    function generateLetters () {
        var chars = 'abcdefghijklmnopqrstuvwxyz',
        stringLength = 1,
        randomstring = '';
        for(var i = 0; i < stringLength; i++) {
          var rnum = Math.floor(Math.random() * chars.length);
          randomstring += chars.substring(rnum, rnum + 1);
        }
        var top = Math.floor(Math.random() * 400),
        left = Math.floor(Math.random() * 700);

        $('#container').append('<div class="letter letter'+ randomstring +'" style="left:'+ left +'px;top:'+ top +'px;background-color:'+ randomColor({luminosity: 'light', hue: 'random'}) +'">'+ randomstring.toUpperCase() +'</div>');
    }


})(jQuery);