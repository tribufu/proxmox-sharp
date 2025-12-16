#!/usr/bin/env pwsh

$env:CSHARP_POST_PROCESS_FILE = ""

java -jar ./vendor/openapi-generator/openapi-generator-cli.jar generate `
    -i ./vendor/spec.v2.yaml `
    -g csharp `
    -o . `
    --global-property apis,models,supportingFiles,apiDocs=false,modelDocs=false,apiTests=false,modelTests=false `
    --additional-properties=packageName=ProxmoxSharp,library=restsharp,zeroBasedEnums=true,nullableReferenceTypes=true `
    --openapi-normalizer SET_TAGS_FOR_ALL_OPERATIONS=ProxmoxGenerated `
    --type-mappings Any=object `
    --skip-validate-spec
