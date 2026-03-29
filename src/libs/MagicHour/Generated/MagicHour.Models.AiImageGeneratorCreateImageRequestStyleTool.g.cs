
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// The art style to use for image generation. Defaults to 'general' if not provided.<br/>
    /// Default Value: general<br/>
    /// Example: ai-anime-generator
    /// </summary>
    public enum AiImageGeneratorCreateImageRequestStyleTool
    {
        /// <summary>
        /// 
        /// </summary>
        AiAnimeGenerator,
        /// <summary>
        /// 
        /// </summary>
        AiArtGenerator,
        /// <summary>
        /// 
        /// </summary>
        AiBackgroundGenerator,
        /// <summary>
        /// 
        /// </summary>
        AiCharacterGenerator,
        /// <summary>
        /// 
        /// </summary>
        AiFaceGenerator,
        /// <summary>
        /// 
        /// </summary>
        AiFashionGenerator,
        /// <summary>
        /// 
        /// </summary>
        AiIconGenerator,
        /// <summary>
        /// 
        /// </summary>
        AiIllustrationGenerator,
        /// <summary>
        /// 
        /// </summary>
        AiInteriorDesignGenerator,
        /// <summary>
        /// 
        /// </summary>
        AiLandscapeGenerator,
        /// <summary>
        /// 
        /// </summary>
        AiLogoGenerator,
        /// <summary>
        /// 
        /// </summary>
        AiMangaGenerator,
        /// <summary>
        /// 
        /// </summary>
        AiOutfitGenerator,
        /// <summary>
        /// 
        /// </summary>
        AiPatternGenerator,
        /// <summary>
        /// 
        /// </summary>
        AiPhotoGenerator,
        /// <summary>
        /// 
        /// </summary>
        AiSketchGenerator,
        /// <summary>
        /// 
        /// </summary>
        AiTattooGenerator,
        /// <summary>
        /// 
        /// </summary>
        AlbumCoverGenerator,
        /// <summary>
        /// 
        /// </summary>
        AnimatedCharactersGenerator,
        /// <summary>
        /// 
        /// </summary>
        ArchitectureGenerator,
        /// <summary>
        /// 
        /// </summary>
        BookCoverGenerator,
        /// <summary>
        /// 
        /// </summary>
        ComicBookGenerator,
        /// <summary>
        /// 
        /// </summary>
        DarkFantasyAi,
        /// <summary>
        /// 
        /// </summary>
        DisneyAiGenerator,
        /// <summary>
        /// 
        /// </summary>
        DndAiArtGenerator,
        /// <summary>
        /// 
        /// </summary>
        EmojiGenerator,
        /// <summary>
        /// 
        /// </summary>
        FantasyMapGenerator,
        /// <summary>
        /// 
        /// </summary>
        General,
        /// <summary>
        /// 
        /// </summary>
        GraffitiGenerator,
        /// <summary>
        /// 
        /// </summary>
        MoviePosterGenerator,
        /// <summary>
        /// 
        /// </summary>
        OpticalIllusionGenerator,
        /// <summary>
        /// 
        /// </summary>
        PokemonGenerator,
        /// <summary>
        /// 
        /// </summary>
        SouthParkCharacterGenerator,
        /// <summary>
        /// 
        /// </summary>
        SuperheroGenerator,
        /// <summary>
        /// 
        /// </summary>
        ThumbnailMaker,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AiImageGeneratorCreateImageRequestStyleToolExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiImageGeneratorCreateImageRequestStyleTool value)
        {
            return value switch
            {
                AiImageGeneratorCreateImageRequestStyleTool.AiAnimeGenerator => "ai-anime-generator",
                AiImageGeneratorCreateImageRequestStyleTool.AiArtGenerator => "ai-art-generator",
                AiImageGeneratorCreateImageRequestStyleTool.AiBackgroundGenerator => "ai-background-generator",
                AiImageGeneratorCreateImageRequestStyleTool.AiCharacterGenerator => "ai-character-generator",
                AiImageGeneratorCreateImageRequestStyleTool.AiFaceGenerator => "ai-face-generator",
                AiImageGeneratorCreateImageRequestStyleTool.AiFashionGenerator => "ai-fashion-generator",
                AiImageGeneratorCreateImageRequestStyleTool.AiIconGenerator => "ai-icon-generator",
                AiImageGeneratorCreateImageRequestStyleTool.AiIllustrationGenerator => "ai-illustration-generator",
                AiImageGeneratorCreateImageRequestStyleTool.AiInteriorDesignGenerator => "ai-interior-design-generator",
                AiImageGeneratorCreateImageRequestStyleTool.AiLandscapeGenerator => "ai-landscape-generator",
                AiImageGeneratorCreateImageRequestStyleTool.AiLogoGenerator => "ai-logo-generator",
                AiImageGeneratorCreateImageRequestStyleTool.AiMangaGenerator => "ai-manga-generator",
                AiImageGeneratorCreateImageRequestStyleTool.AiOutfitGenerator => "ai-outfit-generator",
                AiImageGeneratorCreateImageRequestStyleTool.AiPatternGenerator => "ai-pattern-generator",
                AiImageGeneratorCreateImageRequestStyleTool.AiPhotoGenerator => "ai-photo-generator",
                AiImageGeneratorCreateImageRequestStyleTool.AiSketchGenerator => "ai-sketch-generator",
                AiImageGeneratorCreateImageRequestStyleTool.AiTattooGenerator => "ai-tattoo-generator",
                AiImageGeneratorCreateImageRequestStyleTool.AlbumCoverGenerator => "album-cover-generator",
                AiImageGeneratorCreateImageRequestStyleTool.AnimatedCharactersGenerator => "animated-characters-generator",
                AiImageGeneratorCreateImageRequestStyleTool.ArchitectureGenerator => "architecture-generator",
                AiImageGeneratorCreateImageRequestStyleTool.BookCoverGenerator => "book-cover-generator",
                AiImageGeneratorCreateImageRequestStyleTool.ComicBookGenerator => "comic-book-generator",
                AiImageGeneratorCreateImageRequestStyleTool.DarkFantasyAi => "dark-fantasy-ai",
                AiImageGeneratorCreateImageRequestStyleTool.DisneyAiGenerator => "disney-ai-generator",
                AiImageGeneratorCreateImageRequestStyleTool.DndAiArtGenerator => "dnd-ai-art-generator",
                AiImageGeneratorCreateImageRequestStyleTool.EmojiGenerator => "emoji-generator",
                AiImageGeneratorCreateImageRequestStyleTool.FantasyMapGenerator => "fantasy-map-generator",
                AiImageGeneratorCreateImageRequestStyleTool.General => "general",
                AiImageGeneratorCreateImageRequestStyleTool.GraffitiGenerator => "graffiti-generator",
                AiImageGeneratorCreateImageRequestStyleTool.MoviePosterGenerator => "movie-poster-generator",
                AiImageGeneratorCreateImageRequestStyleTool.OpticalIllusionGenerator => "optical-illusion-generator",
                AiImageGeneratorCreateImageRequestStyleTool.PokemonGenerator => "pokemon-generator",
                AiImageGeneratorCreateImageRequestStyleTool.SouthParkCharacterGenerator => "south-park-character-generator",
                AiImageGeneratorCreateImageRequestStyleTool.SuperheroGenerator => "superhero-generator",
                AiImageGeneratorCreateImageRequestStyleTool.ThumbnailMaker => "thumbnail-maker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiImageGeneratorCreateImageRequestStyleTool? ToEnum(string value)
        {
            return value switch
            {
                "ai-anime-generator" => AiImageGeneratorCreateImageRequestStyleTool.AiAnimeGenerator,
                "ai-art-generator" => AiImageGeneratorCreateImageRequestStyleTool.AiArtGenerator,
                "ai-background-generator" => AiImageGeneratorCreateImageRequestStyleTool.AiBackgroundGenerator,
                "ai-character-generator" => AiImageGeneratorCreateImageRequestStyleTool.AiCharacterGenerator,
                "ai-face-generator" => AiImageGeneratorCreateImageRequestStyleTool.AiFaceGenerator,
                "ai-fashion-generator" => AiImageGeneratorCreateImageRequestStyleTool.AiFashionGenerator,
                "ai-icon-generator" => AiImageGeneratorCreateImageRequestStyleTool.AiIconGenerator,
                "ai-illustration-generator" => AiImageGeneratorCreateImageRequestStyleTool.AiIllustrationGenerator,
                "ai-interior-design-generator" => AiImageGeneratorCreateImageRequestStyleTool.AiInteriorDesignGenerator,
                "ai-landscape-generator" => AiImageGeneratorCreateImageRequestStyleTool.AiLandscapeGenerator,
                "ai-logo-generator" => AiImageGeneratorCreateImageRequestStyleTool.AiLogoGenerator,
                "ai-manga-generator" => AiImageGeneratorCreateImageRequestStyleTool.AiMangaGenerator,
                "ai-outfit-generator" => AiImageGeneratorCreateImageRequestStyleTool.AiOutfitGenerator,
                "ai-pattern-generator" => AiImageGeneratorCreateImageRequestStyleTool.AiPatternGenerator,
                "ai-photo-generator" => AiImageGeneratorCreateImageRequestStyleTool.AiPhotoGenerator,
                "ai-sketch-generator" => AiImageGeneratorCreateImageRequestStyleTool.AiSketchGenerator,
                "ai-tattoo-generator" => AiImageGeneratorCreateImageRequestStyleTool.AiTattooGenerator,
                "album-cover-generator" => AiImageGeneratorCreateImageRequestStyleTool.AlbumCoverGenerator,
                "animated-characters-generator" => AiImageGeneratorCreateImageRequestStyleTool.AnimatedCharactersGenerator,
                "architecture-generator" => AiImageGeneratorCreateImageRequestStyleTool.ArchitectureGenerator,
                "book-cover-generator" => AiImageGeneratorCreateImageRequestStyleTool.BookCoverGenerator,
                "comic-book-generator" => AiImageGeneratorCreateImageRequestStyleTool.ComicBookGenerator,
                "dark-fantasy-ai" => AiImageGeneratorCreateImageRequestStyleTool.DarkFantasyAi,
                "disney-ai-generator" => AiImageGeneratorCreateImageRequestStyleTool.DisneyAiGenerator,
                "dnd-ai-art-generator" => AiImageGeneratorCreateImageRequestStyleTool.DndAiArtGenerator,
                "emoji-generator" => AiImageGeneratorCreateImageRequestStyleTool.EmojiGenerator,
                "fantasy-map-generator" => AiImageGeneratorCreateImageRequestStyleTool.FantasyMapGenerator,
                "general" => AiImageGeneratorCreateImageRequestStyleTool.General,
                "graffiti-generator" => AiImageGeneratorCreateImageRequestStyleTool.GraffitiGenerator,
                "movie-poster-generator" => AiImageGeneratorCreateImageRequestStyleTool.MoviePosterGenerator,
                "optical-illusion-generator" => AiImageGeneratorCreateImageRequestStyleTool.OpticalIllusionGenerator,
                "pokemon-generator" => AiImageGeneratorCreateImageRequestStyleTool.PokemonGenerator,
                "south-park-character-generator" => AiImageGeneratorCreateImageRequestStyleTool.SouthParkCharacterGenerator,
                "superhero-generator" => AiImageGeneratorCreateImageRequestStyleTool.SuperheroGenerator,
                "thumbnail-maker" => AiImageGeneratorCreateImageRequestStyleTool.ThumbnailMaker,
                _ => null,
            };
        }
    }
}