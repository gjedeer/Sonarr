﻿using NzbDrone.Core.MediaFiles.MediaInfo;
using Sonarr.Http.REST;

namespace Sonarr.Api.V3.EpisodeFiles
{
    public class MediaInfoResource : RestResource
    {
        public decimal AudioChannels { get; set; }
        public string AudioCodec { get; set; }
        public string VideoCodec { get; set; }
    }

    public static class MediaInfoResourceMapper
    {
        public static MediaInfoResource ToResource(this MediaInfoModel model, string sceneName)
        {
            return new MediaInfoResource
                   {
                       AudioChannels = MediaInfoFormatter.FormatAudioChannels(model),
                       AudioCodec = MediaInfoFormatter.FormatAudioCodec(model),
                       VideoCodec = MediaInfoFormatter.FormatVideoCodec(model, sceneName)
                   };
        }
    }
}
