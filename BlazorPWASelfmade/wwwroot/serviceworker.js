﻿console.log("This is service worker talking!");
var cacheName = 'blazor-pwa-sample';
var filesToCache = [
    './',
    //Html and css files
    './index.html',
    './css/site.css',
    './css/bootstrap/bootstrap.min.css',
    './css/open-iconic/font/css/open-iconic-bootstrap.min.css', 
    './css/open-iconic/font/fonts/open-iconic.woff',
    //Blazor framework
    './_framework/blazor.webassembly.js',
    './_framework/blazor.boot.json',
    //Our additional files
    './manifest.json',
    './serviceworker.js',
    './icons/icon-192x192.png',
    './icons/icon-512x512.png',
    //The web assembly/.net dll's
    './_framework/wasm/dotnet.js',
    './_framework/wasm/dotnet.wasm',
    './_framework/_bin/WebAssembly.Net.Http.dll',
    './_framework/_bin/Microsoft.AspNetCore.Blazor.HttpClient.dll',
    './_framework/_bin/Microsoft.AspNetCore.Blazor.dll',
    './_framework/_bin/Microsoft.AspNetCore.Components.dll',
    './_framework/_bin/Microsoft.AspNetCore.Components.Web.dll',
    './_framework/_bin/Microsoft.Extensions.DependencyInjection.Abstractions.dll',
    './_framework/_bin/Microsoft.Extensions.DependencyInjection.dll',
    './_framework/_bin/Microsoft.JSInterop.dll',
    './_framework/_bin/mscorlib.dll',
    './_framework/_bin/System.Net.Http.dll',
    './_framework/_bin/Mono.WebAssembly.Interop.dll',
    './_framework/_bin/System.dll',
    './_framework/_bin/System.Core.dll', 
    './_framework/_bin/Microsoft.Bcl.AsyncInterfaces.dll', 
    './_framework/_bin/Microsoft.Extensions.Configuration.Abstractions.dll', 
    './_framework/_bin/Microsoft.Extensions.Logging.Abstractions.dll', 
    './_framework/_bin/Microsoft.Extensions.Primitives.dll', 
    './_framework/_bin/Microsoft.Extensions.Configuration.dll',
    './_framework/_bin/System.Text.Encodings.Web.dll', 
    './_framework/_bin/System.Text.Json.dll', 
    './_framework/_bin/WebAssembly.Bindings.dll', 
    './_framework/_bin/System.Runtime.CompilerServices.Unsafe.dll', 
    //The compiled project .dll's
    './_framework/_bin/DotnetPwaSample.dll'
];

self.addEventListener('install', function (e) {
    console.log('[ServiceWorker] Install');
    e.waitUntil(
        caches.open(cacheName).then(function (cache) {
            console.log('[ServiceWorker] Caching app shell');
            return cache.addAll(filesToCache); 
        })
    );
});

self.addEventListener('activate', event => {
    event.waitUntil(self.clients.claim());
});

self.addEventListener('fetch', event => {
    event.respondWith(
        caches.match(event.request, { ignoreSearch: true }).then(response => {
            return response || fetch(event.request);
        })
    );
});