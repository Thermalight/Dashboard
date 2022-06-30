import { currentPage } from "./stores";

export default function navigate(href) {
    let h = href.replace(/^\//, "").split(/[?#]/g)[0];
    currentPage.set(h);
    history.pushState({}, document.title, "/" + h);
}