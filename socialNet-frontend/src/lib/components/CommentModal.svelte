<script lang="ts">
  import { fade, fly } from 'svelte/transition';
  import { commentModal } from '../stores';
  import { onMount } from 'svelte';
  import { Button } from 'flowbite-svelte';
  let comment = '';
  let textareaEl: HTMLTextAreaElement;

  function close() {
    commentModal.set({ open: false, postId: null });
  }

  function submit() {
    // Aquí iría la lógica para enviar el comentario
    close();
  }

  onMount(() => {
    textareaEl?.focus();
  });
</script>

{#if $commentModal.open}
  <div class="fixed inset-0 bg-black/40 flex items-center justify-center z-50" transition:fade>
    <div class="bg-card rounded-xl p-8 shadow-xl w-full max-w-lg" transition:fly={{ y: 40, duration: 300 }}>
      <h2 class="text-xl font-bold mb-4 text-white">Comentar</h2>
      <textarea
        bind:this={textareaEl}
        bind:value={comment}
        rows="4"
        class="w-full p-3 rounded-lg border border-bg bg-bg text-white resize-none focus:border-primary transition"
        placeholder="Escribe tu comentario…"
      ></textarea>
      <div class="flex justify-end mt-4 gap-2">
        <Button color="light" on:click={close}>Cancelar</Button>
        <Button color="pink" on:click={submit}>Enviar</Button>
      </div>
    </div>
  </div>
{/if}
