<script lang="ts">
  import { onMount } from 'svelte';
  import { posts, commentModal } from '$lib/stores';
  import { getFeed } from '$lib/api';
  import PostCard from '$lib/components/PostCard.svelte';
  import CommentModal from '$lib/components/CommentModal.svelte';
  import { Spinner } from 'flowbite-svelte';

  let loading = true;

  onMount(async () => {
    posts.set(await getFeed());
    loading = false;
  });

  $: $posts;
</script>

<section class="p-8 max-w-2xl mx-auto">
  {#if loading}
    <div class="flex flex-col gap-4 items-center justify-center py-8">
      <Spinner size="xl" color="pink" />
      <span class="text-white">Cargando...</span>
    </div>
  {:else}
    {#each $posts as post, i (post.id)}
      <PostCard {post} index={i} on:comment={e => commentModal.set({ open: true, postId: e.detail })} />
    {/each}
  {/if}
  <CommentModal />
</section>
