import { initSearch } from './search.js';

const elements = {
    ul: $('#customer-suggestions'),
    selectedIdInput: $('#customer-id-input'),
    searchInput: $('#customer-search-input'),
    selectedBox: $('#customer-selected-box'),
    selectedPrimary: $('#customer-selected-primary'),
    selectedSecondary: $('#customer-selected-secondary'),
    clearBtn: $('#customer-clear-btn'),
};
const url = elements.searchInput.data('searchUrl');

initSearch(elements, fetchSuggestions, beforeFetch);

let runningRequest;

function fetchSuggestions(normalizedInput) {
    const data = {
        searchQuery: normalizedInput
    };

    runningRequest = $.getJSON(url, data);
    const currRequest = runningRequest;

    runningRequest.always(() => {
        if (currRequest === runningRequest) {
            runningRequest = null;
        }
    });

    return currRequest;
}

function beforeFetch() {
    if (runningRequest) {
        runningRequest.abort();
    }
}