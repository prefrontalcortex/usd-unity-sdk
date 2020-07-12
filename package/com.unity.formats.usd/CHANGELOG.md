# Changes in pfc Version

## [1.0.3-pfc.5] - 2020-07-12
- ignore test files in releases

## [1.0.3-pfc.4] - 2020-07-07
- fixed PBR export for standard
- improved ChannelCombiner to combine textures on export
- improved texture handling on export
- removed some unnecessary logs
- added examples for PBR export

## [1.0.3-pfc.3] - 2020-04-25
- fix InitUsd package scope (hardcoded)

## [1.0.3-pfc.2] - 2020-04-24
- fixing texture export from memory (textures that are not on disk or not supported)
- fix QuickLook animation export
- fix texture properties (wrap and colorization)
- add ability to export USDZ from timeline recorder clip

## [1.0.2-pfc.2] - 2020-01-16
- re-released with com.unity scope

## [1.0.1-preview.2] - 2019-10-26
- released as pfc package with custom fixes

# Changes in usd-unitysdk for Unity

## [1.0.3-preview.1] - 2020-04-01
### Changed
- Fix the "Slow and safe as FBX" loading mode to perform the basis change as the FBX importer (#129)
 
## [1.0.2-preview.1] - 2019-11-06
### Added
- Option to handle basis conversion "as FBX" (#129)
- Support for "Sphere" schema (#128)

### Changed
- Fix the "Decompose" function to handle matrices with very small determinant (#130, #142)
- Allow exporting transparency from Standard shader (#131)
- Fix the "ImportMesh" sample to works in edit mode (#128)
- Handle skinned primitive that inherits skeleton data (joint indices and weight) from parent prim but don't define those themselves (#128)


## [1.0.1-preview.1] - 2019-06-30
### Changes

New feature :
- Linux support

Bug fixes :
- NullReferenceException on USD export (#67)
- Path of .usd file does not match textures in the archive (#88)
- Build error when sample is imported
- Timeline: Playback sometimes spews errors (#93)
- Skeleton bindings below the root are not discovered (#92)
- Normals update after opening standard shader (#91)
- UsdSkel export fails when rig root is the model root (#89)
- VariantSets on the root UsdAsset results in errors (#77)
- Bones do not match bindpose (#98)
- Standard shader "pops" when opening the inspector (#102)
- UsdIo: Do not recurse on null objects (#118)

## [1.0.0-preview.4] - 2019-03-15
### Changes
- Update readme images

## [1.0.0-preview.3] - 2019-03-15
### Changes
- CI integration
- Samples Fixes

## [1.0.0-preview.1] - 2019-02-20
### Changes
- Initial creation of the package
