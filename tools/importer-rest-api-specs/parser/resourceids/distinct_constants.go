package resourceids

import (
	"github.com/hashicorp/pandora/tools/importer-rest-api-specs/models"
	"github.com/hashicorp/pandora/tools/importer-rest-api-specs/parser/internal"
)

func (p *Parser) findDistinctConstants(input map[string]models.ParsedResourceId) (*map[string]models.ConstantDetails, error) {
	intermediate := internal.ParseResult{
		Constants: map[string]models.ConstantDetails{},
	}

	for _, item := range input {
		intermediate.AppendConstants(item.Constants)
	}

	return &intermediate.Constants, nil
}
