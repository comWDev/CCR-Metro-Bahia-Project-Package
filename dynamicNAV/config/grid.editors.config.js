[
    {
        "name": "Rich text editor",
        "alias": "rte",
        "view": "rte",
        "icon": "icon-article"
    },
    {
        "name": "Image",
        "alias": "media",
        "view": "media",
        "icon": "icon-picture"
    },
    {
        "name": "Macro",
        "alias": "macro",
        "view": "macro",
        "icon": "icon-settings-alt"
    },
    {
        "name": "Embed",
        "alias": "embed",
        "view": "embed",
        "icon": "icon-movie-alt"
    },
    {
        "name": "Headline",
        "alias": "headline",
        "view": "textstring",
        "icon": "icon-coin",
        "config": {
            "style": "font-size: 36px; line-height: 45px; font-weight: bold",
            "markup": "<h1>#value#</h1>"
        }
    },
    {
        "name": "Quote",
        "alias": "quote",
        "view": "textstring",
        "icon": "icon-quote",
        "config": {
            "style": "border-left: 3px solid #ccc; padding: 10px; color: #ccc; font-family: serif; font-style: italic; font-size: 18px",
            "markup": "<blockquote>#value#</blockquote>"
        }
    },
    {
        "name": "Carousel",
        "alias": "carousel",
        "view": "/App_Plugins/LeBlender/editors/leblendereditor/LeBlendereditor.html",
        "icon": "icon-axis-rotation-2",
        "render": "/App_Plugins/LeBlender/editors/leblendereditor/views/Base.cshtml",
        "config": {
            "editors": [
                {
                    "name": "Image",
                    "alias": "image",
                    "propretyType": {},
                    "dataType": "0d3091d8-92c2-4dd9-b72b-ded59ccf54b9"
                },
                {
                    "name": "Title",
                    "alias": "title",
                    "propretyType": {},
                    "dataType": "0cc0eba1-9960-42c9-bf9b-60e150b429ae"
                },
                {
                    "name": "Summary",
                    "alias": "summary",
                    "propretyType": {},
                    "dataType": "c6bac0dd-4ab9-45b1-8e30-e4b619ee5da3"
                }
            ],
            "frontView": "~/Views/Partials/Grid/Editors/carousel.cshtml",
            "renderInGrid": "1",
            "min": 1,
            "max": 5,
            "expiration": 120
        }
    },
    {
        "name": "Highlight",
        "alias": "highlight",
        "view": "/App_Plugins/LeBlender/editors/leblendereditor/LeBlendereditor.html",
        "icon": "icon-lightbulb-active",
        "render": "/App_Plugins/LeBlender/editors/leblendereditor/views/Base.cshtml",
        "config": {
            "editors": [
                {
                    "name": "Image",
                    "alias": "image",
                    "propretyType": {},
                    "dataType": "760b113c-199f-4095-a450-c8f3ff785c2a"
                },
                {
                    "name": "Title",
                    "alias": "title",
                    "propretyType": {},
                    "dataType": "0cc0eba1-9960-42c9-bf9b-60e150b429ae"
                },
                {
                    "name": "Summary",
                    "alias": "summary",
                    "propretyType": {},
                    "dataType": "c6bac0dd-4ab9-45b1-8e30-e4b619ee5da3"
                }
            ],
            "min": 1,
            "max": 1,
            "expiration": 120,
            "frontView": "~/Views/Partials/Grid/Editors/highlight.cshtml",
            "renderInGrid": "1"
        }
    },
    {
        "name": "tabs",
        "alias": "tabs",
        "view": "/App_Plugins/LeBlender/editors/leblendereditor/LeBlendereditor.html",
        "icon": "icon-panel-show",
        "render": "/App_Plugins/LeBlender/editors/leblendereditor/views/Base.cshtml",
        "config": {
            "editors": [
                {
                    "name": "Nome",
                    "alias": "nome",
                    "propretyType": {},
                    "dataType": "0cc0eba1-9960-42c9-bf9b-60e150b429ae"
                },
                {
                    "name": "Tab Numero",
                    "alias": "tabNumero",
                    "propretyType": {},
                    "dataType": "0cc0eba1-9960-42c9-bf9b-60e150b429ae"
                },
                {
                    "name": "Tab Title",
                    "alias": "tabTitle",
                    "propretyType": {},
                    "dataType": "0cc0eba1-9960-42c9-bf9b-60e150b429ae"
                },
                {
                    "name": "Tab Texto",
                    "alias": "tabTexto",
                    "propretyType": {},
                    "dataType": "bd079ef5-b716-4cff-9fa0-1456c8f9d169"
                },
                {
                    "name": "Anchor ID",
                    "alias": "anchorID",
                    "propretyType": {},
                    "dataType": "0cc0eba1-9960-42c9-bf9b-60e150b429ae"
                },
                {
                    "name": "Select Image",
                    "alias": "selectImage",
                    "propretyType": {},
                    "dataType": "2e42a328-793d-40f0-8736-356d9e1125b7"
                },
                {
                    "name": "Tab Cor",
                    "alias": "tabCor",
                    "propretyType": {},
                    "dataType": "32d0aed3-5538-4a65-b6cf-07bff8d8915a"
                }
            ],
            "renderInGrid": "1",
            "min": 0,
            "max": 5,
            "expiration": 120,
            "frontView": ""
        }
    }
]