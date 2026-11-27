import { initSearch } from './search.js'

const elements = {
    ul: $('#model-suggestions'),
    selectedIdInput: $('#model-id-input'),
    searchInput: $('#model-search-input'),
};
const suggestions = elements.ul.data('suggestionList');
const dropdownLimit = elements.ul.data('dropdownSuggestionsLimit');

initSearch(elements, fetchSuggestions)

function fetchSuggestions(userInput) {
    const normalizedInput = userInput.toLowerCase();

    return suggestions
        .filter(s => s.displayText.toLowerCase().includes(normalizedInput))
        .slice(0, dropdownLimit);
}