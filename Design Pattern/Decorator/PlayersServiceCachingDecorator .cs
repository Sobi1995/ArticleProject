﻿using System;
using System.Collections.Generic;
using Microsoft.Extensions.Caching.Memory;

namespace Decorator
{
    public class PlayersServiceCachingDecorator : IPlayersService
    {
        private readonly IPlayersService _playersService;
        private readonly IMemoryCache _memoryCache;

        private const string GET_PLAYERS_LIST_CACHE_KEY = "players.list";

        public PlayersServiceCachingDecorator(IPlayersService playersService/*, IMemoryCache memoryCache*/)
        {
            _playersService = playersService;
            //_memoryCache = memoryCache;
        }

        public IEnumerable<Player> GetPlayersList()
        {
            IEnumerable<Player> players = null;
            Console.WriteLine("Implement Fake PlayersServiceCachingDecorator");
            // Look for the cache key.
       //     if (!_memoryCache.TryGetValue(GET_PLAYERS_LIST_CACHE_KEY, out players))
           // {
                // Cache key is not in cache, so fetch players list.
                players = _playersService.GetPlayersList();

                // Set cache options
            //    var cacheEntryOptions = new MemoryCacheEntryOptions()
                    // Keep the players in cache for this time, reset time if accessed.
                //    .SetSlidingExpiration(TimeSpan.FromMinutes(1));


                // Save players list in cache.
//_memoryCache.Set(GET_PLAYERS_LIST_CACHE_KEY, players, cacheEntryOptions);
          //  }

            return players;
        }
    }
}