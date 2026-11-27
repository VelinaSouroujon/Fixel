import { initSearch } from './search.js';

const elements = {
    ul: $('#customer-suggestions'),
    selectedIdInput: $('#customer-id-input'),
    searchInput: $('#customer-search-input'),
};
const url = elements.searchInput.data('searchUrl');

initSearch(elements, fetchSuggestions, beforeFetch);

let runningRequest;

function fetchSuggestions(userInput) {
    const data = {
        searchQuery: userInput
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