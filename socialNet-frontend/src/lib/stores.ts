// src/lib/stores.ts
import { writable } from 'svelte/store';

export interface User {
  name: string;
  avatar: string;
}
export interface Post {
  id: string;
  author: User;
  date: string;
  image?: string;
  body: string;
  liked: boolean;
  likes: number;
}

export const user = writable<User | null>(null);
export const posts = writable<Post[]>([]);
export const notifications = writable<number>(3);
export const commentModal = writable<{ open: boolean; postId: string | null }>({ open: false, postId: null });
