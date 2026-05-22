# Changelog

## Unreleased
- Added support for the `<Refer>` BXML verb (including `<SipUri>` child, `referCompleteUrl`, `referCompleteMethod`, and optional `tag`).
- Added support for the `referComplete` webhook via `ReferCompleteCallback`.
- Added support for `referCallStatus`, optional `referSipResponseCode`, and optional `notifySipResponseCode` fields.

> Note: This change should not be released before https://github.com/Bandwidth/api-specs/pull/2142 is merged.
