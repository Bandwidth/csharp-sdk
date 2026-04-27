#!/bin/bash

# Generates new test files for models. Run from the root.

# allow generator to write test files
sed -i.bak 's/^src\/Bandwidth\.Standard\.Test\//# src\/Bandwidth.Standard.Test\//' .openapi-generator-ignore && rm .openapi-generator-ignore.bak
# remove current test files for models
rm -f ./src/Bandwidth.Standard.Test/Unit/Model/*
# generate new test files for models
openapi-generator-cli generate -i bandwidth.yml -o ./ -c openapi-config.yml -g csharp > /dev/null
# move generated test files to the correct location
mv ./src/Bandwidth.Standard.Test/Model/* ./src/Bandwidth.Standard.Test/Unit/Model/
# fix namespace declarations in moved test files
sed -i '' 's/namespace Bandwidth\.Standard\.Test\.Model/namespace Bandwidth.Standard.Test.Unit.Model/g' ./src/Bandwidth.Standard.Test/Unit/Model/*.cs
# remove the rest of the generated files
rm -rf ./src/Bandwidth.Standard.Test/Api ./src/Bandwidth.Standard.Test/Model
# discard changes to modified files only (leaves deletions and new test files intact)
modified=$(git diff --name-only --diff-filter=M) && [ -n "$modified" ] && echo "$modified" | xargs git checkout --
