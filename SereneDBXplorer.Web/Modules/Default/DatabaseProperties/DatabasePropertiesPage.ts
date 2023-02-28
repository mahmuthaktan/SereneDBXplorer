import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { DatabasePropertiesGrid } from './DatabasePropertiesGrid';

$(function() {
    initFullHeightGridPage(new DatabasePropertiesGrid($('#GridDiv')).element);
});