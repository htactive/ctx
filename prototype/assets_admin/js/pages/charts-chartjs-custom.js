
//------------- Sparklines in header stats -------------//


	
//generate random number for charts
	randNum = function(){
		//return Math.floor(Math.random()*101);
		return (Math.floor( Math.random()* (1+40-20) ) ) + 20;
	}
	
	
//------------- Bar chart  -------------//
	var barChartData = {
		labels : ["Tháng 1","Tháng 2","Tháng 3","Tháng 4","Tháng 5","Tháng 6","Tháng 7", "Tháng 8", "Tháng 9", "Tháng 10", "Tháng 11", "Tháng 12"],
		datasets : [
			{
				fillColor : "rgba(186,195,210,0.5)",
				strokeColor : "rgba(186,195,210,0.3)",
				highlightFill: "rgba(186,195,210,0.75)",
				highlightStroke: "rgba(186,195,210,1)",
				data : [3+randNum(),5+randNum(),8+randNum(),13+randNum(),17+randNum(),21+randNum(),20+randNum(),15+randNum(),23+randNum(),11+randNum(),23+randNum(),26+randNum()]
			},
			{
				fillColor : "rgba(96,177,204,0.5)",
				strokeColor : "rgba(96,177,204,0.3)",
				highlightFill : "rgba(96,177,204,0.75)",
				highlightStroke : "rgba(96,177,204,1)",
				data : [randNum()-5,randNum()-2,randNum()-4,randNum()-1,randNum()-3,randNum()-2,randNum()-5, randNum()-5,randNum()-5,randNum()-5,randNum()-5,randNum()-5]
			}
		]
	}

	var ctxBar = document.getElementById("bar-chartjs").getContext("2d");
	myBar = new Chart(ctxBar).Bar(barChartData, {
		responsive : true,
		scaleShowGridLines : true,
    	scaleGridLineColor : "#bfbfbf",
    	scaleGridLineWidth : 0.2,
    	//bar options
    	barShowStroke : true,
    	barStrokeWidth : 2,
    	barValueSpacing : 5,
    	barDatasetSpacing : 2,
    	//animations
    	animation: true,
    	animationSteps: 60,
    	animationEasing: "easeOutQuart",
    	//scale
    	showScale: true,
    	scaleFontFamily: "'Roboto'",
    	scaleFontSize: 13,
    	scaleFontStyle: "normal",
    	scaleFontColor: "#333",
    	scaleBeginAtZero : true,
    	//tooltips
    	showTooltips: true,
    	tooltipFillColor: "#344154",
    	tooltipFontFamily: "'Roboto'",
    	tooltipFontSize: 13,
    	tooltipFontColor: "#fff",
    	tooltipYPadding: 8,
    	tooltipXPadding: 10,
    	tooltipCornerRadius: 2,
    	tooltipTitleFontFamily: "'Roboto'",
	});