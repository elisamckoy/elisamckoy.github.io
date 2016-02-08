(function(){
	var app=angular.module('store', []);
	app.controller('StoreController', function(){
		this.products=examples;
	});
	var examples = [
		{
			name: 'Yeti',
			description:'Character study made in Maya',
			image: '../img/yeti_1.jpg'
		},
		{
			name: 'Nightmare',
			description:'University project, creating a space with the theme of Nightmare Before Christmas',
			link: 'https://www.youtube.com/watch?v=qq4n0ioRbvs',
			image: '../img/cat_1.jpg'
		},
		{
			name: 'TipJar',
			description: 'TipJar was a project with a team of 7, we were given the task to make an app with a time frame of 1 week',
			link: 'http://tipjarwellington.herokuapp.com/',
			image: '../img/cat_2.jpg'
		},
		{
			name: 'Irridesent',
			description: 'a fun personal project using Ajax and javascript',
			image: '../img/cat_3.jpg'
		}
	]
})();