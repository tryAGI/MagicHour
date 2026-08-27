
#nullable enable

namespace MagicHour
{
    /// <summary>
    /// The camera effect used to create the output video<br/>
    /// Example: Simple Zoom In
    /// </summary>
    public enum AnimationCreateVideoRequestStyleCameraEffect
    {
        /// <summary>
        ///
        /// </summary>
        Accelerate,
        /// <summary>
        ///
        /// </summary>
        AggressiveZoomInAudioSync,
        /// <summary>
        ///
        /// </summary>
        AggressiveZoomOutAudioSync,
        /// <summary>
        ///
        /// </summary>
        BoostZoomIn,
        /// <summary>
        ///
        /// </summary>
        BoostZoomOut,
        /// <summary>
        ///
        /// </summary>
        BounceInAndOut,
        /// <summary>
        ///
        /// </summary>
        BounceOut,
        /// <summary>
        ///
        /// </summary>
        BounceOutAudioSync,
        /// <summary>
        ///
        /// </summary>
        BounceAndSpinAudioSync,
        /// <summary>
        ///
        /// </summary>
        BounceInPlace,
        /// <summary>
        ///
        /// </summary>
        CogInTheMachine,
        /// <summary>
        ///
        /// </summary>
        DevolveAudioSync,
        /// <summary>
        ///
        /// </summary>
        DirectedByAi,
        /// <summary>
        ///
        /// </summary>
        DramaticZoomIn,
        /// <summary>
        ///
        /// </summary>
        DramaticZoomOut,
        /// <summary>
        ///
        /// </summary>
        DriftSpin,
        /// <summary>
        ///
        /// </summary>
        EarthquakeBounce,
        /// <summary>
        ///
        /// </summary>
        EarthquakeBounceAudioSync,
        /// <summary>
        ///
        /// </summary>
        EvolveAudioSync,
        /// <summary>
        ///
        /// </summary>
        Heartbeat,
        /// <summary>
        ///
        /// </summary>
        HesitateIn,
        /// <summary>
        ///
        /// </summary>
        Jump,
        /// <summary>
        ///
        /// </summary>
        PanLeft,
        /// <summary>
        ///
        /// </summary>
        PanRight,
        /// <summary>
        ///
        /// </summary>
        PulseAudioSync,
        /// <summary>
        ///
        /// </summary>
        Pusher,
        /// <summary>
        ///
        /// </summary>
        PusherAudioSync,
        /// <summary>
        ///
        /// </summary>
        Quadrant,
        /// <summary>
        ///
        /// </summary>
        RiseAndClimb,
        /// <summary>
        ///
        /// </summary>
        RoadTrip,
        /// <summary>
        ///
        /// </summary>
        Rodeo,
        /// <summary>
        ///
        /// </summary>
        RollIn,
        /// <summary>
        ///
        /// </summary>
        RollInAudioSync,
        /// <summary>
        ///
        /// </summary>
        RollingBounces,
        /// <summary>
        ///
        /// </summary>
        RubberBand,
        /// <summary>
        ///
        /// </summary>
        SimpleZoomIn,
        /// <summary>
        ///
        /// </summary>
        SimpleZoomOut,
        /// <summary>
        ///
        /// </summary>
        SliceBounce,
        /// <summary>
        ///
        /// </summary>
        Slideshow,
        /// <summary>
        ///
        /// </summary>
        SpeedOfLight,
        /// <summary>
        ///
        /// </summary>
        SpinBounce,
        /// <summary>
        ///
        /// </summary>
        SwayOut,
        /// <summary>
        ///
        /// </summary>
        SwayOutAudioSync,
        /// <summary>
        ///
        /// </summary>
        TiltDown,
        /// <summary>
        ///
        /// </summary>
        TiltUp,
        /// <summary>
        ///
        /// </summary>
        Traverse,
        /// <summary>
        ///
        /// </summary>
        Tron,
        /// <summary>
        ///
        /// </summary>
        Vertigo,
        /// <summary>
        ///
        /// </summary>
        VertigoAudioSync,
        /// <summary>
        ///
        /// </summary>
        ZoomInAudioSync,
        /// <summary>
        ///
        /// </summary>
        ZoomInAndSpinAudioSync,
        /// <summary>
        ///
        /// </summary>
        ZoomOutAudioSync,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnimationCreateVideoRequestStyleCameraEffectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnimationCreateVideoRequestStyleCameraEffect value)
        {
            return value switch
            {
                AnimationCreateVideoRequestStyleCameraEffect.Accelerate => "Accelerate",
                AnimationCreateVideoRequestStyleCameraEffect.AggressiveZoomInAudioSync => "Aggressive Zoom In - Audio Sync",
                AnimationCreateVideoRequestStyleCameraEffect.AggressiveZoomOutAudioSync => "Aggressive Zoom Out - Audio Sync",
                AnimationCreateVideoRequestStyleCameraEffect.BoostZoomIn => "Boost Zoom In",
                AnimationCreateVideoRequestStyleCameraEffect.BoostZoomOut => "Boost Zoom Out",
                AnimationCreateVideoRequestStyleCameraEffect.BounceInAndOut => "Bounce In And Out",
                AnimationCreateVideoRequestStyleCameraEffect.BounceOut => "Bounce Out",
                AnimationCreateVideoRequestStyleCameraEffect.BounceOutAudioSync => "Bounce Out - Audio Sync",
                AnimationCreateVideoRequestStyleCameraEffect.BounceAndSpinAudioSync => "Bounce and Spin - Audio Sync",
                AnimationCreateVideoRequestStyleCameraEffect.BounceInPlace => "Bounce in Place",
                AnimationCreateVideoRequestStyleCameraEffect.CogInTheMachine => "Cog in the Machine",
                AnimationCreateVideoRequestStyleCameraEffect.DevolveAudioSync => "Devolve - Audio Sync",
                AnimationCreateVideoRequestStyleCameraEffect.DirectedByAi => "Directed by AI",
                AnimationCreateVideoRequestStyleCameraEffect.DramaticZoomIn => "Dramatic Zoom In",
                AnimationCreateVideoRequestStyleCameraEffect.DramaticZoomOut => "Dramatic Zoom Out",
                AnimationCreateVideoRequestStyleCameraEffect.DriftSpin => "Drift Spin",
                AnimationCreateVideoRequestStyleCameraEffect.EarthquakeBounce => "Earthquake Bounce",
                AnimationCreateVideoRequestStyleCameraEffect.EarthquakeBounceAudioSync => "Earthquake Bounce - Audio Sync",
                AnimationCreateVideoRequestStyleCameraEffect.EvolveAudioSync => "Evolve - Audio Sync",
                AnimationCreateVideoRequestStyleCameraEffect.Heartbeat => "Heartbeat",
                AnimationCreateVideoRequestStyleCameraEffect.HesitateIn => "Hesitate In",
                AnimationCreateVideoRequestStyleCameraEffect.Jump => "Jump",
                AnimationCreateVideoRequestStyleCameraEffect.PanLeft => "Pan Left",
                AnimationCreateVideoRequestStyleCameraEffect.PanRight => "Pan Right",
                AnimationCreateVideoRequestStyleCameraEffect.PulseAudioSync => "Pulse - Audio Sync",
                AnimationCreateVideoRequestStyleCameraEffect.Pusher => "Pusher",
                AnimationCreateVideoRequestStyleCameraEffect.PusherAudioSync => "Pusher - Audio Sync",
                AnimationCreateVideoRequestStyleCameraEffect.Quadrant => "Quadrant",
                AnimationCreateVideoRequestStyleCameraEffect.RiseAndClimb => "Rise and Climb",
                AnimationCreateVideoRequestStyleCameraEffect.RoadTrip => "Road Trip",
                AnimationCreateVideoRequestStyleCameraEffect.Rodeo => "Rodeo",
                AnimationCreateVideoRequestStyleCameraEffect.RollIn => "Roll In",
                AnimationCreateVideoRequestStyleCameraEffect.RollInAudioSync => "Roll In - Audio Sync",
                AnimationCreateVideoRequestStyleCameraEffect.RollingBounces => "Rolling Bounces",
                AnimationCreateVideoRequestStyleCameraEffect.RubberBand => "Rubber Band",
                AnimationCreateVideoRequestStyleCameraEffect.SimpleZoomIn => "Simple Zoom In",
                AnimationCreateVideoRequestStyleCameraEffect.SimpleZoomOut => "Simple Zoom Out",
                AnimationCreateVideoRequestStyleCameraEffect.SliceBounce => "Slice Bounce",
                AnimationCreateVideoRequestStyleCameraEffect.Slideshow => "Slideshow",
                AnimationCreateVideoRequestStyleCameraEffect.SpeedOfLight => "Speed of Light",
                AnimationCreateVideoRequestStyleCameraEffect.SpinBounce => "Spin Bounce",
                AnimationCreateVideoRequestStyleCameraEffect.SwayOut => "Sway Out",
                AnimationCreateVideoRequestStyleCameraEffect.SwayOutAudioSync => "Sway Out - Audio Sync",
                AnimationCreateVideoRequestStyleCameraEffect.TiltDown => "Tilt Down",
                AnimationCreateVideoRequestStyleCameraEffect.TiltUp => "Tilt Up",
                AnimationCreateVideoRequestStyleCameraEffect.Traverse => "Traverse",
                AnimationCreateVideoRequestStyleCameraEffect.Tron => "Tron",
                AnimationCreateVideoRequestStyleCameraEffect.Vertigo => "Vertigo",
                AnimationCreateVideoRequestStyleCameraEffect.VertigoAudioSync => "Vertigo - Audio Sync",
                AnimationCreateVideoRequestStyleCameraEffect.ZoomInAudioSync => "Zoom In - Audio Sync",
                AnimationCreateVideoRequestStyleCameraEffect.ZoomInAndSpinAudioSync => "Zoom In and Spin - Audio Sync",
                AnimationCreateVideoRequestStyleCameraEffect.ZoomOutAudioSync => "Zoom Out - Audio Sync",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnimationCreateVideoRequestStyleCameraEffect? ToEnum(string value)
        {
            return value switch
            {
                "Accelerate" => AnimationCreateVideoRequestStyleCameraEffect.Accelerate,
                "Aggressive Zoom In - Audio Sync" => AnimationCreateVideoRequestStyleCameraEffect.AggressiveZoomInAudioSync,
                "Aggressive Zoom Out - Audio Sync" => AnimationCreateVideoRequestStyleCameraEffect.AggressiveZoomOutAudioSync,
                "Boost Zoom In" => AnimationCreateVideoRequestStyleCameraEffect.BoostZoomIn,
                "Boost Zoom Out" => AnimationCreateVideoRequestStyleCameraEffect.BoostZoomOut,
                "Bounce In And Out" => AnimationCreateVideoRequestStyleCameraEffect.BounceInAndOut,
                "Bounce Out" => AnimationCreateVideoRequestStyleCameraEffect.BounceOut,
                "Bounce Out - Audio Sync" => AnimationCreateVideoRequestStyleCameraEffect.BounceOutAudioSync,
                "Bounce and Spin - Audio Sync" => AnimationCreateVideoRequestStyleCameraEffect.BounceAndSpinAudioSync,
                "Bounce in Place" => AnimationCreateVideoRequestStyleCameraEffect.BounceInPlace,
                "Cog in the Machine" => AnimationCreateVideoRequestStyleCameraEffect.CogInTheMachine,
                "Devolve - Audio Sync" => AnimationCreateVideoRequestStyleCameraEffect.DevolveAudioSync,
                "Directed by AI" => AnimationCreateVideoRequestStyleCameraEffect.DirectedByAi,
                "Dramatic Zoom In" => AnimationCreateVideoRequestStyleCameraEffect.DramaticZoomIn,
                "Dramatic Zoom Out" => AnimationCreateVideoRequestStyleCameraEffect.DramaticZoomOut,
                "Drift Spin" => AnimationCreateVideoRequestStyleCameraEffect.DriftSpin,
                "Earthquake Bounce" => AnimationCreateVideoRequestStyleCameraEffect.EarthquakeBounce,
                "Earthquake Bounce - Audio Sync" => AnimationCreateVideoRequestStyleCameraEffect.EarthquakeBounceAudioSync,
                "Evolve - Audio Sync" => AnimationCreateVideoRequestStyleCameraEffect.EvolveAudioSync,
                "Heartbeat" => AnimationCreateVideoRequestStyleCameraEffect.Heartbeat,
                "Hesitate In" => AnimationCreateVideoRequestStyleCameraEffect.HesitateIn,
                "Jump" => AnimationCreateVideoRequestStyleCameraEffect.Jump,
                "Pan Left" => AnimationCreateVideoRequestStyleCameraEffect.PanLeft,
                "Pan Right" => AnimationCreateVideoRequestStyleCameraEffect.PanRight,
                "Pulse - Audio Sync" => AnimationCreateVideoRequestStyleCameraEffect.PulseAudioSync,
                "Pusher" => AnimationCreateVideoRequestStyleCameraEffect.Pusher,
                "Pusher - Audio Sync" => AnimationCreateVideoRequestStyleCameraEffect.PusherAudioSync,
                "Quadrant" => AnimationCreateVideoRequestStyleCameraEffect.Quadrant,
                "Rise and Climb" => AnimationCreateVideoRequestStyleCameraEffect.RiseAndClimb,
                "Road Trip" => AnimationCreateVideoRequestStyleCameraEffect.RoadTrip,
                "Rodeo" => AnimationCreateVideoRequestStyleCameraEffect.Rodeo,
                "Roll In" => AnimationCreateVideoRequestStyleCameraEffect.RollIn,
                "Roll In - Audio Sync" => AnimationCreateVideoRequestStyleCameraEffect.RollInAudioSync,
                "Rolling Bounces" => AnimationCreateVideoRequestStyleCameraEffect.RollingBounces,
                "Rubber Band" => AnimationCreateVideoRequestStyleCameraEffect.RubberBand,
                "Simple Zoom In" => AnimationCreateVideoRequestStyleCameraEffect.SimpleZoomIn,
                "Simple Zoom Out" => AnimationCreateVideoRequestStyleCameraEffect.SimpleZoomOut,
                "Slice Bounce" => AnimationCreateVideoRequestStyleCameraEffect.SliceBounce,
                "Slideshow" => AnimationCreateVideoRequestStyleCameraEffect.Slideshow,
                "Speed of Light" => AnimationCreateVideoRequestStyleCameraEffect.SpeedOfLight,
                "Spin Bounce" => AnimationCreateVideoRequestStyleCameraEffect.SpinBounce,
                "Sway Out" => AnimationCreateVideoRequestStyleCameraEffect.SwayOut,
                "Sway Out - Audio Sync" => AnimationCreateVideoRequestStyleCameraEffect.SwayOutAudioSync,
                "Tilt Down" => AnimationCreateVideoRequestStyleCameraEffect.TiltDown,
                "Tilt Up" => AnimationCreateVideoRequestStyleCameraEffect.TiltUp,
                "Traverse" => AnimationCreateVideoRequestStyleCameraEffect.Traverse,
                "Tron" => AnimationCreateVideoRequestStyleCameraEffect.Tron,
                "Vertigo" => AnimationCreateVideoRequestStyleCameraEffect.Vertigo,
                "Vertigo - Audio Sync" => AnimationCreateVideoRequestStyleCameraEffect.VertigoAudioSync,
                "Zoom In - Audio Sync" => AnimationCreateVideoRequestStyleCameraEffect.ZoomInAudioSync,
                "Zoom In and Spin - Audio Sync" => AnimationCreateVideoRequestStyleCameraEffect.ZoomInAndSpinAudioSync,
                "Zoom Out - Audio Sync" => AnimationCreateVideoRequestStyleCameraEffect.ZoomOutAudioSync,
                _ => null,
            };
        }
    }
}