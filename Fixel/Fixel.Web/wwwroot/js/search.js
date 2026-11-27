import { DISPLAY_NONE_CLASS, MIN_SEARCH_LENGTH, SUGGESTION_ITEM_CLASS } from './shared/constants.js';

export function initSearch(elements, fetchSuggestions, beforeFetch) {
    elements.searchInput.on('input', async function() {
        await onInputAsync(elements, fetchSuggestions, beforeFetch);
    });

    elements.ul.on('click', `.${SUGGESTION_ITEM_CLASS}`, function() {
        onSuggestionSelected($(this), elements);
    });
}

async function onInputAsync(elements, fetchSuggestions, beforeFetch) {
    beforeFetch?.();

    elements.selectedIdInput.val('');
    const userInput = elements.searchInput.val().trim();

    if (userInput.length < MIN_SEARCH_LENGTH) {
        removeSuggestionList(elements.ul);

        return;
    }

    try {
        const suggestions = await fetchSuggestions(userInput);
        displaySuggestions(suggestions, elements.ul);
    } catch (error) {
        console.log('Error fetching suggestions', error); // TODO: check whether it's aborted or it's a real error
    }
}

function onSuggestionSelected(eventCurrTarget, elements) {
    elements.searchInput.val(eventCurrTarget.data('display'));
    elements.selectedIdInput.val(eventCurrTarget.data('id'));

    removeSuggestionList(elements.ul);
}

function displaySuggestions(suggestions, ulEl) {
    ulEl.empty();
    ulEl.removeClass(DISPLAY_NONE_CLASS);

    if (suggestions.length === 0) {
        appendNoMatchFound(ulEl);

        return;
    }

    for (const currSuggestion of suggestions) {
        appendSuggestion(currSuggestion, ulEl);
    }
}

function removeSuggestionList(ulEl) {
    ulEl.empty()
        .addClass(DISPLAY_NONE_CLASS);
}

function appendSuggestion(suggestion, ulEl) {
    const suggestionEl = $('<li>')
        .addClass(
            `${SUGGESTION_ITEM_CLASS} list-group-item list-group-item-action d-flex justify-content-between align-items-baseline gap-2`)
        .attr('role', 'button')
        .data('id', suggestion.id)
        .data('display', suggestion.displayText)
        .appendTo(ulEl);

    $('<span>')
        .addClass('text-truncate')
        .text(suggestion.primaryText)
        .appendTo(suggestionEl);

    $('<span>')
        .addClass('small text-body-secondary num')
        .text(suggestion.secondaryText)
        .appendTo(suggestionEl);
}

function appendNoMatchFound(ulEl) {
    $('<li>')
        .addClass('list-group-item text-body-secondary small')
        .text('No matches found')
        .appendTo(ulEl);
}