<script lang="ts">
  import { onMount } from 'svelte';
  import { fade, fly } from 'svelte/transition';
  import Button from '../lib/components/button.svelte';

  let mounted = false;
  let posts = [
    {
      id: 1,
      author: {
        name: 'John Doe',
        avatar: 'https://ui-avatars.com/api/?name=John+Doe'
      },
      content: 'Just launched my new project! Check it out 🚀',
      image: 'https://picsum.photos/800/400?random=1',
      likes: 42,
      comments: 12,
      createdAt: '2h ago'
    },
    // ... more posts ...
  ];

  let featuredUsers = [
    {
      name: 'Sarah Wilson',
      avatar: 'https://ui-avatars.com/api/?name=Sarah+Wilson',
      followers: 1200,
      posts: 86
    },
    // ... more users ...
  ];

  onMount(() => {
    mounted = true;
  });
</script>

<!-- Fondo general -->
<div class="min-h-screen bg-gradient-to-br from-gray-50 via-blue-50 to-purple-100 dark:from-gray-900 dark:via-slate-900 dark:to-blue-950">

  <!-- Hero Section -->
  {#if mounted}
  <section class="relative overflow-hidden py-20">
    <div class="absolute inset-0 pointer-events-none">
      <div class="absolute -top-32 -left-32 w-96 h-96 bg-gradient-to-br from-blue-400/30 to-purple-400/20 rounded-full blur-3xl"></div>
      <div class="absolute -bottom-32 -right-32 w-96 h-96 bg-gradient-to-tr from-purple-400/30 to-pink-400/20 rounded-full blur-3xl"></div>
    </div>
    <div class="relative mx-auto max-w-7xl px-4 sm:px-6 lg:px-8 flex flex-col lg:flex-row items-center gap-16">
      <!-- Hero Text -->
      <div class="flex-1 text-center lg:text-left" in:fly={{ x: -50, duration: 1000 }}>
        <h1 class="text-5xl sm:text-6xl font-extrabold tracking-tight text-gray-900 dark:text-white drop-shadow-lg bg-white/70 dark:bg-gray-900/60 rounded-xl px-4 py-2 inline-block">
          Connect, Share & Engage<br>
          <span class="bg-gradient-to-r from-blue-500 via-purple-500 to-pink-500 bg-clip-text text-transparent">
            with Your Community
          </span>
        </h1> 
        <p class="mt-6 text-lg text-gray-600 dark:text-gray-300 max-w-xl mx-auto lg:mx-0 bg-white/70 dark:bg-gray-900/60 rounded-lg px-4 py-2 shadow">
          Join our social network and start sharing your stories with people who share your interests.
        </p>
        <div class="mt-10 flex flex-wrap justify-center lg:justify-start gap-4">
          <button class="px-8 py-3 text-lg rounded-full shadow-lg bg-blue-500 text-white hover:bg-blue-600 transition font-semibold">Get Started</button>
          <button class="px-8 py-3 text-lg rounded-full bg-white/90 text-blue-500 border border-blue-500 font-semibold shadow hover:bg-blue-50 dark:bg-gray-800 dark:text-blue-400 dark:border-blue-400 transition">Learn More</button>
        </div>
      </div>
      <!-- Hero Image -->
      <div class="flex-1 flex justify-center" in:fly={{ x: 50, duration: 1000, delay: 300 }}>
        <img
          src="https://images.unsplash.com/photo-1519125323398-675f0ddb6308?auto=format&fit=crop&w=600&q=80"
          alt="Hero"
          class="rounded-3xl shadow-2xl border-4 border-white dark:border-gray-800 w-full max-w-md"
        />
      </div>
    </div>
  </section>
  {/if}

  <!-- Recent Posts -->
  <section class="py-16">
    <div class="mx-auto max-w-7xl px-4 sm:px-6 lg:px-8">
      <h2 class="mb-10 text-3xl font-bold text-gray-900 dark:text-white text-center">Recent Posts</h2>
      <div class="grid gap-10 sm:grid-cols-2 lg:grid-cols-3">
        {#each posts as post, i (post.id)}
          <article
            class="overflow-hidden rounded-2xl bg-white/90 dark:bg-gray-800/80 shadow-xl hover:shadow-2xl transition-all border border-gray-100 dark:border-gray-700 flex flex-col"
            in:fade={{ duration: 500, delay: i * 100 }}
          >
            <img src={post.image} alt="" class="w-full h-48 object-cover" />
            <div class="p-6 flex-1 flex flex-col">
              <div class="flex items-center gap-4 mb-4">
                <img src={post.author.avatar} alt={post.author.name} class="h-10 w-10 rounded-full border-2 border-blue-400" />
                <div>
                  <h3 class="font-semibold text-gray-900 dark:text-white">{post.author.name}</h3>
                  <p class="text-xs text-gray-500">{post.createdAt}</p>
                </div>
              </div>
              <p class="text-gray-700 dark:text-gray-200 flex-1">{post.content}</p>
              <div class="mt-6 flex items-center gap-6 text-sm text-gray-500">
                <button class="flex items-center gap-1 hover:text-blue-600 transition-colors">
                  <svg xmlns="http://www.w3.org/2000/svg" class="h-5 w-5" fill="currentColor" viewBox="0 0 20 20">
                    <path d="M3.172 5.172a4 4 0 015.656 0L10 6.343l1.172-1.171a4 4 0 115.656 5.656L10 18.343l-6.828-6.829a4 4 0 010-5.656z"/>
                  </svg>
                  {post.likes}
                </button>
                <button class="flex items-center gap-1 hover:text-blue-600 transition-colors">
                  <svg xmlns="http://www.w3.org/2000/svg" class="h-5 w-5" fill="currentColor" viewBox="0 0 20 20">
                    <path fill-rule="evenodd" d="M18 10c0 3.866-3.582 7-8 7a8.841 8.841 0 01-4.083-.98L2 17l1.338-3.123C2.493 12.767 2 11.434 2 10c0-3.866 3.582-7 8-7s8 3.134 8 7zM7 9H5v2h2V9zm8 0h-2v2h2V9zM9 9h2v2H9V9z" clip-rule="evenodd"/>
                  </svg>
                  {post.comments}
                </button>
              </div>
            </div>
          </article>
        {/each}
      </div>
    </div>
  </section>

  <!-- Featured Users -->
  <section class="bg-gradient-to-r from-blue-50 via-purple-50 to-pink-50 dark:from-gray-900 dark:via-slate-900 dark:to-blue-950 py-16">
    <div class="mx-auto max-w-7xl px-4 sm:px-6 lg:px-8">
      <h2 class="mb-10 text-3xl font-bold text-gray-900 dark:text-white text-center">Featured Users</h2>
      <div class="grid gap-10 sm:grid-cols-2 lg:grid-cols-4">
        {#each featuredUsers as user, i}
          <div
            class="flex flex-col items-center rounded-2xl bg-white/90 dark:bg-gray-800/80 p-8 text-center shadow-xl hover:shadow-2xl transition-all border border-gray-100 dark:border-gray-700"
            in:fade={{ duration: 500, delay: i * 100 }}
          >
            <img src={user.avatar} alt={user.name} class="h-20 w-20 rounded-full mb-4 border-4 border-blue-400 shadow-lg" />
            <h3 class="font-semibold text-gray-900 dark:text-white text-lg">{user.name}</h3>
            <div class="flex gap-2 justify-center mt-2 mb-4">
              <span class="inline-block bg-blue-100 text-blue-700 dark:bg-blue-900 dark:text-blue-200 rounded-full px-3 py-1 text-xs font-semibold">{user.followers} followers</span>
              <span class="inline-block bg-purple-100 text-purple-700 dark:bg-purple-900 dark:text-purple-200 rounded-full px-3 py-1 text-xs font-semibold">{user.posts} publicaciones</span>
            </div>
            <Button variant="secondary" className="rounded-full px-6 py-2">Seguir</Button>
          </div>
        {/each}
      </div>
    </div>
  </section>
</div>

<style>
  /* Puedes agregar animaciones personalizadas aquí si lo deseas */
</style>
