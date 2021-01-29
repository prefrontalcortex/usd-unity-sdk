# Changes in pfc Version

## [2.0.0-pfc] - 2021-01-30
- updated/rebased to unity package 2.0.0-exp.1 as base
- fixed nullrefs when trying to export audio clips that are null or disabled
- fixed in-prefab parenting issues on export
- changed SetupTexture to be public so other material exporters can use it

## [1.0.3-pfc.9] - 2020-08-24
- added experimental UsdAudio support
  - support for looping / non-looping audio
  - support for spatial / non-spatial audio
  - no support for audio clips in Timeline yet;
    needs to be an AudioSource in the scene to be exported

## [1.0.3-pfc.8] - 2020-07-24
- better PBR export for both built-in and HDRP
- fix texture export from disk in packages
- fix texture conversion in some edge cases

## [1.0.3-pfc.7] - 2020-07-12
- ignore test files in releases
- fix meta file for Tests folder

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

## [2.0.0-exp.1] - 2020-12-21
### Features
- Updated USD version to v20.08
- Set material name in Unity to match the material name in the USD file on import (#174).
- Shader exporter: added PBR export support to standard shader (#191, #206).
- Shader exporter: added support for in-memory and render texture export (#125).
- Shader exporter: added support for texture wrap modes (#125).
- Added USDZ export from recorder clip.
- Added Scope import as XForm (#154).

### Bug Fixes
- Fixed a crash happening when calling Scene.Read on non existing prims (#158).
- Fixed an inability to refresh layers in Editor Mode (#155).
- Fixed USDPayload's "Is Loaded" field in the inspector staying at false even when the payload has been loaded.
- Fixed Transform Overrides export extension (USDU-124)
- Fixed UsdAsset not saving changes made in the inspector (simple view).
- Fixed redundant Timesamples created every frame for every prims at export.
- Fixed shader import for emissive color & light baking.
- Fixed wrong texture paths when exporting from packages (#125).
- Fixed prefabs being reset when entering Play mode (#101).
- Fixed export framerate to frames (60FPS) for more stability and improved compatibility with ArQuickLook (#170)

Special thanks to Felix Herbst for his awesome contributions on the materials import/export and USDZ exporters.

## [1.0.3-preview.2] - 2020-04-24
### Changed
- Fix regression where the default usd root was ignored, creating broken hierarchies of game objects

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
