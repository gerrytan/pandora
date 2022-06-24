package parser

import (
	"strings"

	"github.com/hashicorp/pandora/tools/importer-rest-api-specs/models"
	"github.com/hashicorp/pandora/tools/importer-rest-api-specs/parser/internal"
)

var _ customFieldMatcher = tagsMatcher{}

type tagsMatcher struct{}

func (tagsMatcher) isMatch(field models.FieldDetails, definition models.ObjectDefinition, known internal.ParseResult) bool {
	return strings.EqualFold(field.JsonName, "tags") && definition.Type == models.ObjectDefinitionDictionary && definition.NestedItem.Type == models.ObjectDefinitionString
}

func (tagsMatcher) customFieldType() models.CustomFieldType {
	return models.CustomFieldTypeTags
}
