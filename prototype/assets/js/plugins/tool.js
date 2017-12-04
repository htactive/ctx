
	$(document).ready(function () {
		function clearColor(){
			$('body').removeClass('color-yellow color-lightblue color-pink color-turquoise color-orange color-orange-sec')
		}
		
		$('.tools a').on('click', function(e){
			e.preventDefault();
			var $this = $(this);
			
			if ($this.hasClass('color-yellow')){
				clearColor();
				$('body').addClass('color-yellow')
			}
			if ($this.hasClass('color-lightblue')){
				clearColor();
				$('body').addClass('color-lightblue')
			}
			if ($this.hasClass('color-pink')){
				clearColor();
				$('body').addClass('color-pink')
			}
			if ($this.hasClass('color-turquoise')){
				clearColor();
				$('body').addClass('color-turquoise')
			}
			if ($this.hasClass('color-orange')){
				clearColor();
				$('body').addClass('color-orange')
			}
			if ($this.hasClass('color-orange-sec')){
				clearColor();
				$('body').addClass('color-orange-sec')
			}
			if ($this.hasClass('color-blue')){
				clearColor();
			}
		})
	
	})
