﻿// Copyright (c) 2007-2017 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using System.Collections.Generic;
using osu.Framework.Allocation;
using osu.Framework.Testing;
using osu.Game.Database;
using osu.Game.Overlays;

namespace osu.Desktop.VisualTests.Tests
{
    public class TestCaseDirect : TestCase
    {
        public override string Description => @"osu!direct overlay";

        private DirectOverlay direct;
        private RulesetDatabase rulesets;

        public override void Reset()
        {
            base.Reset();

            Add(direct = new DirectOverlay());
            newBeatmaps();

            AddStep(@"toggle", direct.ToggleVisibility);
            AddStep(@"result counts", () => direct.ResultAmounts = new DirectOverlay.ResultCounts(1, 4, 13));
        }

        [BackgroundDependencyLoader]
        private void load(RulesetDatabase rulesets)
        {
            this.rulesets = rulesets;
        }

        private void newBeatmaps()
        {
            var ruleset = rulesets.GetRuleset(0);

            direct.BeatmapSets = new[]
            {
                new BeatmapSetInfo
                {
                    Metadata = new BeatmapMetadata
                    {
                        Title = @"OrVid",
                        Artist = @"An",
                        Author = @"RLC",
                        Source = @"",
                    },
                    Beatmaps = new List<BeatmapInfo>
                    {
                        new BeatmapInfo
                        {
                            Ruleset = ruleset,
                            StarDifficulty = 5.35f,
                            Metadata = new BeatmapMetadata(),
                            OnlineInfo = new BeatmapOnlineInfo
                            {
                                Covers = new[] { @"https://assets.ppy.sh//beatmaps/578332/covers/cover.jpg?1494591390" },
                                Preview = @"https://b.ppy.sh/preview/578332.mp3",
                                PlayCount = 97,
                                FavouriteCount = 72,
                            },
                        },
                    },
                },
                new BeatmapSetInfo
                {
                    Metadata = new BeatmapMetadata
                    {
                        Title = @"tiny lamp",
                        Artist = @"fhana",
                        Author = @"Sotarks",
                        Source = @"ぎんぎつね",
                    },
                    Beatmaps = new List<BeatmapInfo>
                    {
                        new BeatmapInfo
                        {
                            Ruleset = ruleset,
                            StarDifficulty = 5.81f,
                            Metadata = new BeatmapMetadata(),
                            OnlineInfo = new BeatmapOnlineInfo
                            {
                                Covers = new[] { @"https://assets.ppy.sh//beatmaps/599627/covers/cover.jpg?1494539318" },
                                Preview = @"https//b.ppy.sh/preview/599627.mp3",
                                PlayCount = 3082,
                                FavouriteCount = 14,
                            },
                        },
                    },
                },
                new BeatmapSetInfo
                {
                    Metadata = new BeatmapMetadata
                    {
                        Title = @"At Gwanghwamun",
                        Artist = @"KYUHYUN",
                        Author = @"Cerulean Veyron",
                        Source = @"",
                    },
                    Beatmaps = new List<BeatmapInfo>
                    {
                        new BeatmapInfo
                        {
                            Ruleset = ruleset,
                            StarDifficulty = 0.9f,
                            Metadata = new BeatmapMetadata(),
                            OnlineInfo = new BeatmapOnlineInfo
                            {
                                Covers = new[] { @"https://assets.ppy.sh//beatmaps/513268/covers/cover.jpg?1494502863" },
                                Preview = @"https//b.ppy.sh/preview/513268.mp3",
                                PlayCount = 2762,
                                FavouriteCount = 15,
                            },
                        },
                        new BeatmapInfo
                        {
                            Ruleset = ruleset,
                            StarDifficulty = 1.1f,
                        },
                        new BeatmapInfo
                        {
                            Ruleset = ruleset,
                            StarDifficulty = 2.02f,
                        },
                        new BeatmapInfo
                        {
                            Ruleset = ruleset,
                            StarDifficulty = 3.49f,
                        },
                    },
                },
                new BeatmapSetInfo
                {
                    Metadata = new BeatmapMetadata
                    {
                        Title = @"RHAPSODY OF BLUE SKY",
                        Artist = @"fhana",
                        Author = @"[Kamiya]",
                        Source = @"小林さんちのメイドラゴン",
                    },
                    Beatmaps = new List<BeatmapInfo>
                    {
                        new BeatmapInfo
                        {
                            Ruleset = ruleset,
                            StarDifficulty = 1.26f,
                            Metadata = new BeatmapMetadata(),
                            OnlineInfo = new BeatmapOnlineInfo
                            {
                                Covers = new[] { @"https://assets.ppy.sh//beatmaps/586841/covers/cover.jpg?1494052741" },
                                Preview = @"https//b.ppy.sh/preview/586841.mp3",
                                PlayCount = 62317,
                                FavouriteCount = 161,
                            },
                        },
                        new BeatmapInfo
                        {
                            Ruleset = ruleset,
                            StarDifficulty = 2.01f,
                        },
                        new BeatmapInfo
                        {
                            Ruleset = ruleset,
                            StarDifficulty = 2.87f,
                        },
                        new BeatmapInfo
                        {
                            Ruleset = ruleset,
                            StarDifficulty = 3.76f,
                        },
                        new BeatmapInfo
                        {
                            Ruleset = ruleset,
                            StarDifficulty = 3.93f,
                        },
                        new BeatmapInfo
                        {
                            Ruleset = ruleset,
                            StarDifficulty = 4.37f,
                        },
                        new BeatmapInfo
                        {
                            Ruleset = ruleset,
                            StarDifficulty = 5.13f,
                        },
                        new BeatmapInfo
                        {
                            Ruleset = ruleset,
                            StarDifficulty = 5.42f,
                        },
                    },
                },
            };
        }
    }
}
