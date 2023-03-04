import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { DatabaseDefinitionsGrid } from './DatabaseDefinitionsGrid';

$(function() {
    initFullHeightGridPage(new DatabaseDefinitionsGrid($('#GridDiv')).element);
});