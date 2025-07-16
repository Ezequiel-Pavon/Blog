<script lang="ts">
  const year = new Date().getFullYear();
</script>

<footer class="mt-auto bg-white dark:bg-gray-800">
  <div class="mx-auto w-full max-w-screen-xl p-4 md:py-8">
    <div class="sm:flex sm:items-center sm:justify-between">
      <a href="/" class="mb-4 flex items-center sm:mb-0">
        <span class="self-center text-2xl font-semibold whitespace-nowrap dark:text-white">Social Blog</span>
      </a>
      <ul class="mb-6 flex flex-wrap items-center text-sm font-medium text-gray-500 dark:text-gray-400 sm:mb-0">
        <li>
          <a href="/about" class="mr-4 hover:underline md:mr-6">About</a>
        </li>
        <li>
          <a href="/privacy" class="mr-4 hover:underline md:mr-6">Privacy Policy</a>
        </li>
        <li>
          <a href="/terms" class="mr-4 hover:underline md:mr-6">Terms</a>
        </li>
        <li>
          <a href="/contact" class="hover:underline">Contact</a>
        </li>
      </ul>
    </div>
    <hr class="my-6 border-gray-200 dark:border-gray-700 sm:mx-auto lg:my-8" />
    <span class="block text-sm text-gray-500 dark:text-gray-400 sm:text-center">
      © {year} Social Blog™. All Rights Reserved.
    </span>
  </div>
</footer>