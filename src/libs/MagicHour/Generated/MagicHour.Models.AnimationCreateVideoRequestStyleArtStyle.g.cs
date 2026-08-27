
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// The art style used to create the output video<br/>
    /// Example: Painterly Illustration
    /// </summary>
    public enum AnimationCreateVideoRequestStyleArtStyle
    {
        /// <summary>
        ///
        /// </summary>
        x3dRender,
        /// <summary>
        ///
        /// </summary>
        x90sStreets,
        /// <summary>
        ///
        /// </summary>
        AbstractMinimalist,
        /// <summary>
        ///
        /// </summary>
        Arcane,
        /// <summary>
        ///
        /// </summary>
        ArtDeco,
        /// <summary>
        ///
        /// </summary>
        BoldColoredIllustration,
        /// <summary>
        ///
        /// </summary>
        CinematicLandscape,
        /// <summary>
        ///
        /// </summary>
        CinematicMiyazaki,
        /// <summary>
        ///
        /// </summary>
        Cosmic,
        /// <summary>
        ///
        /// </summary>
        Cubist,
        /// <summary>
        ///
        /// </summary>
        Custom,
        /// <summary>
        ///
        /// </summary>
        Cyberpunk,
        /// <summary>
        ///
        /// </summary>
        DarkGraphicIllustration,
        /// <summary>
        ///
        /// </summary>
        DarkWatercolor,
        /// <summary>
        ///
        /// </summary>
        DirectedByAi,
        /// <summary>
        ///
        /// </summary>
        DoubleExposure,
        /// <summary>
        ///
        /// </summary>
        FadedIllustration,
        /// <summary>
        ///
        /// </summary>
        Fantasy,
        /// <summary>
        ///
        /// </summary>
        FuturisticAnime,
        /// <summary>
        ///
        /// </summary>
        Impressionism,
        /// <summary>
        ///
        /// </summary>
        InkAndWatercolorPortrait,
        /// <summary>
        ///
        /// </summary>
        Inkpunk,
        /// <summary>
        ///
        /// </summary>
        IntricateAbstractLinesPortrait,
        /// <summary>
        ///
        /// </summary>
        JacksonPollock,
        /// <summary>
        ///
        /// </summary>
        LandscapePainting,
        /// <summary>
        ///
        /// </summary>
        LowPoly,
        /// <summary>
        ///
        /// </summary>
        Miniatures,
        /// <summary>
        ///
        /// </summary>
        MinimalColdFuturism,
        /// <summary>
        ///
        /// </summary>
        OilPainting,
        /// <summary>
        ///
        /// </summary>
        OldSchoolComic,
        /// <summary>
        ///
        /// </summary>
        Overgrown,
        /// <summary>
        ///
        /// </summary>
        PaintedCityscape,
        /// <summary>
        ///
        /// </summary>
        PainterlyIllustration,
        /// <summary>
        ///
        /// </summary>
        Photograph,
        /// <summary>
        ///
        /// </summary>
        Pixar,
        /// <summary>
        ///
        /// </summary>
        PixelArt,
        /// <summary>
        ///
        /// </summary>
        Postapocalyptic,
        /// <summary>
        ///
        /// </summary>
        SinCity,
        /// <summary>
        ///
        /// </summary>
        SoftDelicateMattePortrait,
        /// <summary>
        ///
        /// </summary>
        Spooky,
        /// <summary>
        ///
        /// </summary>
        StudioGhibliFilmStill,
        /// <summary>
        ///
        /// </summary>
        Synthwave,
        /// <summary>
        ///
        /// </summary>
        TraditionalWatercolor,
        /// <summary>
        ///
        /// </summary>
        VanGogh,
        /// <summary>
        ///
        /// </summary>
        VibrantMatteIllustration,
        /// <summary>
        ///
        /// </summary>
        VintageJapaneseAnime,
        /// <summary>
        ///
        /// </summary>
        Woodcut,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnimationCreateVideoRequestStyleArtStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnimationCreateVideoRequestStyleArtStyle value)
        {
            return value switch
            {
                AnimationCreateVideoRequestStyleArtStyle.x3dRender => "3D Render",
                AnimationCreateVideoRequestStyleArtStyle.x90sStreets => "90s Streets",
                AnimationCreateVideoRequestStyleArtStyle.AbstractMinimalist => "Abstract Minimalist",
                AnimationCreateVideoRequestStyleArtStyle.Arcane => "Arcane",
                AnimationCreateVideoRequestStyleArtStyle.ArtDeco => "Art Deco",
                AnimationCreateVideoRequestStyleArtStyle.BoldColoredIllustration => "Bold Colored Illustration",
                AnimationCreateVideoRequestStyleArtStyle.CinematicLandscape => "Cinematic Landscape",
                AnimationCreateVideoRequestStyleArtStyle.CinematicMiyazaki => "Cinematic Miyazaki",
                AnimationCreateVideoRequestStyleArtStyle.Cosmic => "Cosmic",
                AnimationCreateVideoRequestStyleArtStyle.Cubist => "Cubist",
                AnimationCreateVideoRequestStyleArtStyle.Custom => "Custom",
                AnimationCreateVideoRequestStyleArtStyle.Cyberpunk => "Cyberpunk",
                AnimationCreateVideoRequestStyleArtStyle.DarkGraphicIllustration => "Dark Graphic Illustration",
                AnimationCreateVideoRequestStyleArtStyle.DarkWatercolor => "Dark Watercolor",
                AnimationCreateVideoRequestStyleArtStyle.DirectedByAi => "Directed by AI",
                AnimationCreateVideoRequestStyleArtStyle.DoubleExposure => "Double Exposure",
                AnimationCreateVideoRequestStyleArtStyle.FadedIllustration => "Faded Illustration",
                AnimationCreateVideoRequestStyleArtStyle.Fantasy => "Fantasy",
                AnimationCreateVideoRequestStyleArtStyle.FuturisticAnime => "Futuristic Anime",
                AnimationCreateVideoRequestStyleArtStyle.Impressionism => "Impressionism",
                AnimationCreateVideoRequestStyleArtStyle.InkAndWatercolorPortrait => "Ink and Watercolor Portrait",
                AnimationCreateVideoRequestStyleArtStyle.Inkpunk => "Inkpunk",
                AnimationCreateVideoRequestStyleArtStyle.IntricateAbstractLinesPortrait => "Intricate Abstract Lines Portrait",
                AnimationCreateVideoRequestStyleArtStyle.JacksonPollock => "Jackson Pollock",
                AnimationCreateVideoRequestStyleArtStyle.LandscapePainting => "Landscape Painting",
                AnimationCreateVideoRequestStyleArtStyle.LowPoly => "Low Poly",
                AnimationCreateVideoRequestStyleArtStyle.Miniatures => "Miniatures",
                AnimationCreateVideoRequestStyleArtStyle.MinimalColdFuturism => "Minimal Cold Futurism",
                AnimationCreateVideoRequestStyleArtStyle.OilPainting => "Oil Painting",
                AnimationCreateVideoRequestStyleArtStyle.OldSchoolComic => "Old School Comic",
                AnimationCreateVideoRequestStyleArtStyle.Overgrown => "Overgrown",
                AnimationCreateVideoRequestStyleArtStyle.PaintedCityscape => "Painted Cityscape",
                AnimationCreateVideoRequestStyleArtStyle.PainterlyIllustration => "Painterly Illustration",
                AnimationCreateVideoRequestStyleArtStyle.Photograph => "Photograph",
                AnimationCreateVideoRequestStyleArtStyle.Pixar => "Pixar",
                AnimationCreateVideoRequestStyleArtStyle.PixelArt => "Pixel Art",
                AnimationCreateVideoRequestStyleArtStyle.Postapocalyptic => "Postapocalyptic",
                AnimationCreateVideoRequestStyleArtStyle.SinCity => "Sin City",
                AnimationCreateVideoRequestStyleArtStyle.SoftDelicateMattePortrait => "Soft Delicate Matte Portrait",
                AnimationCreateVideoRequestStyleArtStyle.Spooky => "Spooky",
                AnimationCreateVideoRequestStyleArtStyle.StudioGhibliFilmStill => "Studio Ghibli Film Still",
                AnimationCreateVideoRequestStyleArtStyle.Synthwave => "Synthwave",
                AnimationCreateVideoRequestStyleArtStyle.TraditionalWatercolor => "Traditional Watercolor",
                AnimationCreateVideoRequestStyleArtStyle.VanGogh => "Van Gogh",
                AnimationCreateVideoRequestStyleArtStyle.VibrantMatteIllustration => "Vibrant Matte Illustration",
                AnimationCreateVideoRequestStyleArtStyle.VintageJapaneseAnime => "Vintage Japanese Anime",
                AnimationCreateVideoRequestStyleArtStyle.Woodcut => "Woodcut",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnimationCreateVideoRequestStyleArtStyle? ToEnum(string value)
        {
            return value switch
            {
                "3D Render" => AnimationCreateVideoRequestStyleArtStyle.x3dRender,
                "90s Streets" => AnimationCreateVideoRequestStyleArtStyle.x90sStreets,
                "Abstract Minimalist" => AnimationCreateVideoRequestStyleArtStyle.AbstractMinimalist,
                "Arcane" => AnimationCreateVideoRequestStyleArtStyle.Arcane,
                "Art Deco" => AnimationCreateVideoRequestStyleArtStyle.ArtDeco,
                "Bold Colored Illustration" => AnimationCreateVideoRequestStyleArtStyle.BoldColoredIllustration,
                "Cinematic Landscape" => AnimationCreateVideoRequestStyleArtStyle.CinematicLandscape,
                "Cinematic Miyazaki" => AnimationCreateVideoRequestStyleArtStyle.CinematicMiyazaki,
                "Cosmic" => AnimationCreateVideoRequestStyleArtStyle.Cosmic,
                "Cubist" => AnimationCreateVideoRequestStyleArtStyle.Cubist,
                "Custom" => AnimationCreateVideoRequestStyleArtStyle.Custom,
                "Cyberpunk" => AnimationCreateVideoRequestStyleArtStyle.Cyberpunk,
                "Dark Graphic Illustration" => AnimationCreateVideoRequestStyleArtStyle.DarkGraphicIllustration,
                "Dark Watercolor" => AnimationCreateVideoRequestStyleArtStyle.DarkWatercolor,
                "Directed by AI" => AnimationCreateVideoRequestStyleArtStyle.DirectedByAi,
                "Double Exposure" => AnimationCreateVideoRequestStyleArtStyle.DoubleExposure,
                "Faded Illustration" => AnimationCreateVideoRequestStyleArtStyle.FadedIllustration,
                "Fantasy" => AnimationCreateVideoRequestStyleArtStyle.Fantasy,
                "Futuristic Anime" => AnimationCreateVideoRequestStyleArtStyle.FuturisticAnime,
                "Impressionism" => AnimationCreateVideoRequestStyleArtStyle.Impressionism,
                "Ink and Watercolor Portrait" => AnimationCreateVideoRequestStyleArtStyle.InkAndWatercolorPortrait,
                "Inkpunk" => AnimationCreateVideoRequestStyleArtStyle.Inkpunk,
                "Intricate Abstract Lines Portrait" => AnimationCreateVideoRequestStyleArtStyle.IntricateAbstractLinesPortrait,
                "Jackson Pollock" => AnimationCreateVideoRequestStyleArtStyle.JacksonPollock,
                "Landscape Painting" => AnimationCreateVideoRequestStyleArtStyle.LandscapePainting,
                "Low Poly" => AnimationCreateVideoRequestStyleArtStyle.LowPoly,
                "Miniatures" => AnimationCreateVideoRequestStyleArtStyle.Miniatures,
                "Minimal Cold Futurism" => AnimationCreateVideoRequestStyleArtStyle.MinimalColdFuturism,
                "Oil Painting" => AnimationCreateVideoRequestStyleArtStyle.OilPainting,
                "Old School Comic" => AnimationCreateVideoRequestStyleArtStyle.OldSchoolComic,
                "Overgrown" => AnimationCreateVideoRequestStyleArtStyle.Overgrown,
                "Painted Cityscape" => AnimationCreateVideoRequestStyleArtStyle.PaintedCityscape,
                "Painterly Illustration" => AnimationCreateVideoRequestStyleArtStyle.PainterlyIllustration,
                "Photograph" => AnimationCreateVideoRequestStyleArtStyle.Photograph,
                "Pixar" => AnimationCreateVideoRequestStyleArtStyle.Pixar,
                "Pixel Art" => AnimationCreateVideoRequestStyleArtStyle.PixelArt,
                "Postapocalyptic" => AnimationCreateVideoRequestStyleArtStyle.Postapocalyptic,
                "Sin City" => AnimationCreateVideoRequestStyleArtStyle.SinCity,
                "Soft Delicate Matte Portrait" => AnimationCreateVideoRequestStyleArtStyle.SoftDelicateMattePortrait,
                "Spooky" => AnimationCreateVideoRequestStyleArtStyle.Spooky,
                "Studio Ghibli Film Still" => AnimationCreateVideoRequestStyleArtStyle.StudioGhibliFilmStill,
                "Synthwave" => AnimationCreateVideoRequestStyleArtStyle.Synthwave,
                "Traditional Watercolor" => AnimationCreateVideoRequestStyleArtStyle.TraditionalWatercolor,
                "Van Gogh" => AnimationCreateVideoRequestStyleArtStyle.VanGogh,
                "Vibrant Matte Illustration" => AnimationCreateVideoRequestStyleArtStyle.VibrantMatteIllustration,
                "Vintage Japanese Anime" => AnimationCreateVideoRequestStyleArtStyle.VintageJapaneseAnime,
                "Woodcut" => AnimationCreateVideoRequestStyleArtStyle.Woodcut,
                _ => null,
            };
        }
    }
}