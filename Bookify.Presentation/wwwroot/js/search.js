$(document).ready(function(){
	var books = new Bloodhound({
		datumTokenizer: Bloodhound.tokenizers.obj.whitespace('Title'),
		queryTokenizer: Bloodhound.tokenizers.whitespace,
		remote: {
			url: '/Search/FindBook?search=%QUERY', // Note , Must delete json extension from %QUERY.json to be %QUERY
			wildcard: '%QUERY'
		}
	});


	$('#remote .typeahead').typeahead( 
		{
			hint: true,
			highlight: true,
			minLength: 4 // Trigger after typing at least 4 characters to reduce request server
		},
		{
			name: 'books',
			limit: 100,    // number of books that will apears in result 
		    display: 'title', // Note must type camelCase
		    source: books,
			templates: {
				empty: [
					'<div class="empty-message">',
					'unable to find any Book with this name!',
					'</div>'
				].join('\n'),
				suggestion: function (data) {
					return '<div class="fw-bold suggest">' + data.title + '</div>'; // Display only the Title
				}
				//suggestion: Handlebars.compile('<div><strong>{{books.title}}</strong></div>') // Note download Handlebars from client-side library
			}
		},
	).on('typeahead:select', function (e, book) {
		window.location.href = `/Search/Details/${book.id}`
	});
})