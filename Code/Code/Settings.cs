// <copyright file="Settings.cs" company="Holger Kühn">
// Copyright (c) 2014 - 2019 Holger Kühn. All rights reserved.
// </copyright>

namespace CollectorzToMediaCenter
{
    using System.Collections.Generic;
    using System.Xml;

    /// <summary>
    /// stores all parameters configured by xml-files<br/>
    /// <br/>
    /// used xml-files<br/>
    /// TranslationLanguageIsoCodeToDescriptionEnUs.xml - provides values used for languageIsoCodeToDescription dictionary in EN-US<br/>
    /// </summary>
    public class Settings
    {
        #region Enums Part 1

        /// <summary>
        /// Translations of file extensions to MimeTypes
        /// <remarks>List from github://cymen/ApacheMimeTypesToDotNet</remarks>
        /// </summary>
        private readonly Dictionary<string, string> translationMimeTypeExtensionToDescription;

        /// <summary>
        /// Translations of ISO-Languagecodes to Description
        /// </summary>
        private readonly Dictionary<string, string> translationLanguageIsoCodeToDescription;
        #endregion
        #region Attributes

        #region Kodi

        #endregion
        #region MovieCollector

        #endregion
        #region Server

        #endregion
        #region Dictionaries

        #endregion
        #region Configuration

        #endregion
        #endregion
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="Settings"/> class.
        /// initializes configuration with settings-files
        /// </summary>
        public Settings()
        {
            #region Kodi

            #endregion
            #region MovieCollector

            #endregion
            #region Server

            #endregion
            #region Dictionaries / Configuration
            #region Translations
            #region Translations - MimeTypeExtensionToDescription
            this.translationMimeTypeExtensionToDescription = new Dictionary<string, string>();

            foreach (XmlNode xmlTranslationLanguageIsoCodeToDescription in BaseClassExtention.XmlReadFile("Settings\\Data\\TranslationMimeTypeExtensionToDescription.xml", "Settings\\Schema\\TranslationMimeTypeExtensionToDescription.xsd", "TranslationMimeTypeExtensionToDescriptions").ChildNodes)
            {
                this.translationMimeTypeExtensionToDescription.Add(xmlTranslationLanguageIsoCodeToDescription.XmlReadSubnode("MimeTypeExtension").InnerText, xmlTranslationLanguageIsoCodeToDescription.XmlReadSubnode("MimeTypeDescription").InnerText);
            }
            #endregion
            #region Translations - LanguageIsoCodeToDescription
            this.translationLanguageIsoCodeToDescription = new Dictionary<string, string>();

            foreach (XmlNode xmlTranslationLanguageIsoCodeToDescription in BaseClassExtention.XmlReadFile("Settings\\Data\\TranslationLanguageIsoCodeToDescriptionEnUs.xml", "Settings\\Schema\\TranslationLanguageIsoCodeToDescriptionEnUs.xsd", "TranslationLanguageIsoCodeToDescriptions").ChildNodes)
            {
                this.translationLanguageIsoCodeToDescription.Add(xmlTranslationLanguageIsoCodeToDescription.XmlReadSubnode("LanguageIsoCode").InnerText, xmlTranslationLanguageIsoCodeToDescription.XmlReadSubnode("LanguageDescription").InnerText);
            }
            #endregion
            #endregion
            #endregion
        }

        #endregion
        #region Enums Part 2

        /// <summary>
        /// List of video codecs used for export to Kodi.
        /// </summary>
        public enum VideoCodec
        {
            /// <summary>
            /// specifies video file as TV recording
            /// </summary>
            TV,

            /// <summary>
            /// specifies video as BluRay content
            /// </summary>
            BluRay,

            /// <summary>
            /// video file with H264 codec
            /// </summary>
            H264,

            /// <summary>
            /// video file with H265 codec
            /// </summary>
            H265
        }

        /// <summary>
        /// List of server types handled by this program.
        /// </summary>
        public enum ListOfServerTypes
        {
            /// <summary>
            /// dictionary from number to name
            /// </summary>
            NumberToName,

            /// <summary>
            /// dictionary from number to associated drive letter
            /// </summary>
            NumberToDriveLetter,

            /// <summary>
            /// dictionary from number to local path for media storage in file system
            /// </summary>
            NumberToDevicePathForPublication,

            /// <summary>
            /// dictionary from number to local path for media publication in file system
            /// </summary>
            NumberToDeviceDestinationPath,

            /// <summary>
            /// dictionary from associated drive letter to name
            /// </summary>
            DriveLetterToName,

            /// <summary>
            /// dictionary from name to associated drive letter
            /// </summary>
            NameToDriveLetter
        }

        /// <summary>
        /// List of AspectRatios handled by this program.
        /// </summary>
        public enum VideoAspectRatio
        {
            /// <summary>
            /// Fullscreen
            /// </summary>
            AspectRatio43,

            /// <summary>
            /// Widescreen
            /// </summary>
            AspectRatio169,

            /// <summary>
            /// Theatrical Widescreen
            /// </summary>
            AspectRatio219
        }

        /// <summary>
        /// List of Video definitions handled by this program.
        /// </summary>
        public enum VideoDefinition
        {
            /// <summary>
            /// SD content
            /// </summary>
            SD,

            /// <summary>
            /// (Full-) HD content
            /// </summary>
            HD
        }

        /// <summary>
        /// List of image types used for publishing in Kodi
        /// </summary>
        public enum ImageType
        {
            /// <summary>
            /// unknown image type
            /// </summary>
            Unknown,

            /// <summary>
            /// image with front cover
            /// </summary>
            CoverFront,

            /// <summary>
            /// image with back cover
            /// </summary>
            CoverBack,

            /// <summary>
            /// image of poster used for fanart
            /// </summary>
            Poster,

            /// <summary>
            /// image of backdrop used for fanart
            /// </summary>
            Backdrop,

            /// <summary>
            /// image of front cover used for seasons
            /// </summary>
            SeasonCover,

            /// <summary>
            /// image of poster used for seasons
            /// </summary>
            SeasonPoster,

            /// <summary>
            /// image of back drop used for seasons
            /// </summary>
            SeasonBackdrop,

            /// <summary>
            /// image of episode cover
            /// </summary>
            EpisodeCover,

            /// <summary>
            /// additional back drops used for fanart
            /// </summary>
            ExtraBackdrop,

            /// <summary>
            /// additional covers used for fanart
            /// </summary>
            ExtraCover
        }

        /// <summary>
        /// Schemes for SRT-files
        /// </summary>
        public enum SrtSubTitleLineType
        {
            /// <summary>
            /// first line of SRT specifications
            /// number of entry
            /// </summary>
            EntryNumber,

            /// <summary>
            /// second line of SRT specifications
            /// times, when the entry should be displayed
            /// </summary>
            Times,

            /// <summary>
            /// third and following lines of SRT specifications
            /// text displayed
            /// </summary>
            SubTitles,

            /// <summary>
            /// last line of SRT specifications
            /// empty line ending the entry
            /// </summary>
            EmptyLine
        }

        /// <summary>
        /// Gets number of ImageTypes; needs to be updated, when new ImageTypes are indroduced
        /// </summary>
        public static int NumberOfImageTypes
        {
            get { return 11; }
        }

        #endregion
        #region Properties
        #region Kodi

        #endregion
        #region MovieCollector

        #endregion
        #region Server

        #endregion
        #region Configuration

        #endregion
        #region Dictionaries

        /// <summary>
        /// Gets list of translations for ISO-codes to descriptions<br/>
        /// </summary>
        /// <returns>list of translations for ISO-codes to descriptions</returns>
        /// [SuppressMessage("StyleCop.CSharp.OrderingRules", "SA1202:ElementsMustBeOrderedByAccess", Justification = "Reviewed.")]
        public Dictionary<string, string> TranslationLanguageIsoCodeToDescription
        {
            get { return this.translationLanguageIsoCodeToDescription; }
        }

        #endregion
        #endregion
        #region Methods

        #endregion
    }
}
