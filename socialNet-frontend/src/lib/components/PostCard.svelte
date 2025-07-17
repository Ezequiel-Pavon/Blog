<script lang="ts">
  import type { Post } from '../stores';
  import { likePost } from '../api';
  import { createEventDispatcher } from 'svelte';
  import { fly } from 'svelte/transition';
  import { tweened } from 'svelte/motion';
  import { cubicOut } from 'svelte/easing';

  export let post: Post;
  export let index = 0;

  let liked = post.liked;
  let likes = post.likes;
  let anim = tweened(1, { duration: 200, easing: cubicOut });
  const dispatch = createEventDispatcher();

  async function handleLike() {
    anim.set(1.2);
    liked = !liked;
    likes += liked ? 1 : -1;
    await likePost(post.id);
    setTimeout(() => anim.set(1), 200);
  }
</script>

<article
  in:fly={{ y: 40, opacity: 0, duration: 400, delay: index * 80 }}
  class="bg-card rounded-xl shadow-lg p-6 mb-6 flex flex-col gap-4"
>
  <div class="flex items-center gap-3">
    <img src={post.author.avatar} alt="avatar" class="w-10 h-10 rounded-full" />
    <div>
      <div class="font-bold">{post.author.name}</div>
      <div class="text-xs text-gray-400">{post.date}</div>
    </div>
  </div>
  {#if post.image}
    <img src={post.image} alt="post image" class="rounded-lg w-full object-cover max-h-64" />
  {/if}
  <div class="text-white">{post.body}</div>
  <div class="flex items-center gap-4">
    <button
      class="flex items-center gap-1 text-primary hover:scale-110 transition"
      on:click={handleLike}
      style="transform: scale({$anim})"
    >
      <span class="i-heroicons-heart-solid" class:animate-bounce={liked}></span>
      <span>{likes}</span>
    </button>
    <button
      class="text-accent hover:underline"
      on:click={() => dispatch('comment', post.id)}
    >
      Comentar
    </button>
  </div>
</article>
