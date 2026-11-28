import { initSearch } from './search.js';

const elements = {
    ul: $('#model-suggestions'),
    selectedIdInput: $('#model-id-input'),
    searchInput: $('#model-search-input'),
    selectedBox: $('#model-selected-box'),
    selectedPrimary: $('#model-selected-primary'),
    selectedSecondary: $('#model-selected-secondary'),
    clearBtn: $('#model-clear-btn'),
};
const suggestions = elements.ul.data('suggestionList');
const dropdownLimit = elements.ul.data('dropdownSuggestionsLimit');

initSearch(elements, fetchSuggestions)

function fetchSuggestions(normalizedInput) {
    const tokens = normalizedInput.split(/\s+/);

    return suggestions
        .filter(s => {
            const textToCompare = `${s.primaryText} ${s.secondaryText ?? ''}`.toLowerCase();
            return tokens.every(t => textToCompare.includes(t));
        })
        .slice(0, dropdownLimit);
}