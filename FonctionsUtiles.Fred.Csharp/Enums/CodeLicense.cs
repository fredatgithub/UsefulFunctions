namespace FonctionsUtiles.Fred.Csharp.Enums
{
  /// <summary>
  /// Licenses than can be searched on GitHub
  /// https://help.github.com/articles/searching-repositories#search-by-license
  /// </summary>
  public enum License
  {
    [Parameter(Value = "afl-3.0")]
    AcademicFree_3_0,
    [Parameter(Value = "apache-2.0")]
    Apache_2_0,
    [Parameter(Value = "artistic-2.0")]
    Artistic_2_0,
    [Parameter(Value = "bsl-1.0")]
    BoostSoftware_1_0,
    [Parameter(Value = "0bsd")]
    BSD0Clause,
    [Parameter(Value = "bsd-2-clause")]
    BSD2Clause,
    [Parameter(Value = "bsd-3-clause")]
    BSD3Clause,
    [Parameter(Value = "bsd-3-clause-clear")]
    BSD3ClauseClear,
    [Parameter(Value = "bsd-4-clause")]
    BSD4Clause,
    [Parameter(Value = "cc")]
    CreativeCommons,
    [Parameter(Value = "cc0-1.0")]
    CreativeCommonsZero_1_0,
    [Parameter(Value = "cc-by-4.0")]
    CreativeCommonsAtrribution_4_0,
    [Parameter(Value = "cc-by-sa-4.0")]
    CreativeCommonsAttributionShareAlike_4_0,
    [Parameter(Value = "cecill-2.1")]
    CeCILL_2_1,
    [Parameter(Value = "wtfpl")]
    DoWhatTheFYouWant,
    [Parameter(Value = "ecl-2.0")]
    EducationalCommunity_2_0,
    [Parameter(Value = "epl-1.0")]
    EclipsePublic_1_0,
    [Parameter(Value = "epl-2.0")]
    EclipsePublic_2_0,
    [Parameter(Value = "eupl-1.1")]
    EuropeanUnionPublic_1_1,
    [Parameter(Value = "eupl-1.2")]
    EuropeanUnionPublic_1_2,
    [Parameter(Value = "agpl-3.0")]
    GNUAfferoGeneralPublic_3_0,
    [Parameter(Value = "gpl")]
    GNUGeneralPublic,
    [Parameter(Value = "gpl-2.0")]
    GNUGeneralPublic_2_0,
    [Parameter(Value = "gpl-3.0")]
    GNUGeneralPublic_3_0,
    [Parameter(Value = "lgpl")]
    GNULesserGeneralPublic,
    [Parameter(Value = "lgpl-2.1")]
    GNULesserGeneralPublic_2_1,
    [Parameter(Value = "lgpl-3.0")]
    GNULesserGeneralPublic_3_0,
    [Parameter(Value = "isc")]
    ISC,
    [Parameter(Value = "lppl-1.3c")]
    LatexProjectPublic,
    [Parameter(Value = "ms-pl")]
    MicrosoftPublic,
    [Parameter(Value = "ms-rl")]
    MicrosoftReciprocal,
    [Parameter(Value = "mit")]
    MIT,
    [Parameter(Value = "mpl-2.0")]
    MozillaPublic_2_0,
    [Parameter(Value = "odbl-1.0")]
    ODCOpenDatabase,
    [Parameter(Value = "osl-3.0")]
    OpenSoftware_3_0,
    [Parameter(Value = "postgresql")]
    PostgreseSQL,
    [Parameter(Value = "ofl-1.1")]
    SILOpenFont,
    [Parameter(Value = "upl-1.0")]
    UniversalPermissive,
    [Parameter(Value = "ncsa")]
    NSCAOpenSource,
    [Parameter(Value = "unlicense")]
    TheUnlicense,
    [Parameter(Value = "vim")]
    Vim,
    [Parameter(Value = "zlib")]
    ZLib
  }
}
