(function(){
	var app=angular.module('store', []);
	app.controller('StoreController', function(){
		this.products=examples;
	});
	var examples = [
		{
			name: 'Yeti',
			detail: 'Animation',
			description:'Character study made in Maya',
			image: '../img/yeti_1.jpg'
		},
		{
			name: 'Nightmare',
			detail: 'Animation',
			description:'University project, creating a space with the theme of Nightmare Before Christmas',
			link: 'https://www.youtube.com/watch?v=qq4n0ioRbvs',
			image: '../img/nightmare.jpg'
		},
		{
			name: 'TipJar',
			detail: 'Web App',
			description: 'TipJar was a project with a team of seven, we were given the task to make an app with a time frame of one week',
			link: 'http://tipjarwellington.herokuapp.com/',
			image: '../img/tipjar.jpg'
		},
		{
			name: 'Irridesent',
			detail: 'Web App',
			description: 'a fun personal project using Ajax and javascript. Created in one week',
			image: '../img/irridesent.jpg'
		},
		{
			name: 'Minesweeper',
			detail: 'Web Game',
			description: 'A three day project with a team of three',
			image: '../img/minesweeper.jpg'
		}
	]
})();

