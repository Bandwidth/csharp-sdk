#!/bin/bash
set -euo pipefail
cd "$(dirname "${BASH_SOURCE[0]}")"

# Pin the JVM to UTC so date examples in generated doc comments don't depend on the local timezone
export JAVA_TOOL_OPTIONS="${JAVA_TOOL_OPTIONS:-} -Duser.timezone=UTC"

npx --yes @openapitools/openapi-generator-cli generate \
  -i bandwidth.yml -g csharp -c openapi-config.yml -o . "$@"
