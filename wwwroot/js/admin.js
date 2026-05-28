const toast = document.getElementById("toast");
const tabByHash = {
  dashboard: "overview",
  requests: "sales",
  tours: "product",
  calendar: "product",
  crm: "operations",
  partners: "operations",
  suppliers: "operations",
  tasks: "operations",
  finance: "finance",
  marketing: "finance",
  reports: "finance",
  settings: "settings",
  security: "settings",
};

let currentRole = "admin";

function submitAdminPassword(password) {
  const token = document.querySelector('input[name="__RequestVerificationToken"]')?.value;
  const form = document.createElement("form");
  form.method = "post";
  form.action = "/Home/AdminLogin";
  form.hidden = true;

  const passwordInput = document.createElement("input");
  passwordInput.name = "password";
  passwordInput.value = password;
  form.append(passwordInput);

  if (token) {
    const tokenInput = document.createElement("input");
    tokenInput.name = "__RequestVerificationToken";
    tokenInput.value = token;
    form.append(tokenInput);
  }

  document.body.append(form);
  form.submit();
}

document.querySelectorAll("img[data-fallback]").forEach((image) => {
  image.addEventListener("error", () => {
    if (image.dataset.fallbackApplied === "true") return;
    image.dataset.fallbackApplied = "true";
    image.src = image.dataset.fallback;
  });
});

function applyNextImageFallback(image) {
  const fallbacks = image.dataset.imageFallbacks?.split("|").filter(Boolean) ?? [];
  if (!fallbacks.length) return;

  const currentIndex = Number.parseInt(image.dataset.fallbackIndex ?? "0", 10);
  const currentSource = image.getAttribute("src");
  const nextImage = fallbacks.find((fallback, index) => index > currentIndex && fallback !== currentSource);
  if (!nextImage) return;

  image.dataset.fallbackIndex = String(fallbacks.indexOf(nextImage));
  image.src = nextImage;
}

document.querySelectorAll("img[data-image-fallbacks]").forEach((image) => {
  image.addEventListener("error", () => applyNextImageFallback(image));
});

function setActiveTab(tabName) {
  const activeRoleView = document.querySelector(`[data-role-view="${currentRole}"]`);
  if (!activeRoleView) return;

  document.querySelectorAll(".tabbar [data-tab]").forEach((button) => {
    button.classList.toggle("active", button.dataset.tab === tabName);
  });

  activeRoleView.querySelectorAll(".tab-panel").forEach((panel) => {
    panel.classList.toggle("active", panel.dataset.panel === tabName);
  });
  activeRoleView.scrollIntoView({ behavior: "smooth", block: "start" });
}

function setRole(roleName) {
  const targetRoleView = document.querySelector(`[data-role-view="${roleName}"]`);
  if (!targetRoleView) {
    if (roleName === "user") {
      window.location.href = "/Home/Customer";
    }
    return;
  }

  currentRole = roleName;
  document.querySelectorAll("[data-role]").forEach((button) => {
    button.classList.toggle("active", button.dataset.role === roleName);
  });
  document.querySelectorAll("[data-role-view]").forEach((view) => {
    view.hidden = view.dataset.roleView !== roleName;
  });
  setActiveTab(document.querySelector(".tabbar [data-tab].active")?.dataset.tab ?? "overview");
}

function showToast(message) {
  if (!toast) return;
  toast.textContent = message;
  toast.hidden = false;
  window.clearTimeout(showToast.timer);
  showToast.timer = window.setTimeout(() => {
    toast.hidden = true;
  }, 2400);
}

if (window.__toastMessage) {
  showToast(window.__toastMessage);
}

function openModal(id) {
  const modal = document.getElementById(id);
  if (!modal) return;
  modal.hidden = false;
  document.body.classList.add("modal-open");
}

function closeModal(target) {
  const modal = target.closest(".modal-backdrop");
  if (!modal) return;
  modal.hidden = true;
  document.body.classList.remove("modal-open");
}

document.addEventListener("click", (event) => {
  const adminGate = event.target.closest("[data-admin-gate]");
  if (adminGate) {
    event.preventDefault();
    openModal("admin-login-modal");
    window.setTimeout(() => {
      const passwordInput = document.querySelector("[data-admin-password]");
      const error = document.querySelector("[data-admin-login-error]");
      if (error) error.hidden = true;
      if (passwordInput) passwordInput.value = "";
      passwordInput?.focus();
    }, 60);
    return;
  }

  const roleButton = event.target.closest("[data-role]");
  if (roleButton) {
    setRole(roleButton.dataset.role);
    showToast(roleButton.dataset.role === "admin" ? "Включен режим администратора" : "Включен режим пользователя");
    return;
  }

  const tabButton = event.target.closest("[data-tab]");
  if (tabButton) {
    setActiveTab(tabButton.dataset.tab);
    return;
  }

  const programDay = event.target.closest("[data-day-title]");
  if (programDay) {
    const viewer = programDay.closest("[data-program-viewer]");
    if (!viewer) return;

    viewer.querySelectorAll("[data-day-title]").forEach((button) => {
      button.classList.toggle("active", button === programDay);
    });

    const title = viewer.querySelector("[data-program-title]");
    const text = viewer.querySelector("[data-program-text]");
    const image = viewer.querySelector("[data-program-image]");

    if (title) title.textContent = programDay.dataset.dayTitle;
    if (text) text.textContent = programDay.dataset.dayText;
    if (image) {
      image.src = programDay.dataset.dayImage;
      image.alt = `${document.title} - ${programDay.dataset.dayTitle}`;
      image.dataset.imageFallbacks = programDay.dataset.dayFallbacks ?? image.dataset.imageFallbacks ?? "";
      image.dataset.fallbackIndex = programDay.dataset.dayImageIndex ?? "0";
    }

    return;
  }

  const openButton = event.target.closest("[data-open]");
  if (openButton) {
    openModal(openButton.dataset.open);
    return;
  }

  const closeButton = event.target.closest("[data-close]");
  if (closeButton) {
    closeModal(closeButton);
    return;
  }

  const scrollButton = event.target.closest("[data-scroll]");
  if (scrollButton) {
    document.querySelector(scrollButton.dataset.scroll)?.scrollIntoView({ behavior: "smooth", block: "start" });
    return;
  }

  const demoSubmit = event.target.closest("[data-demo-submit]");
  if (demoSubmit) {
    closeModal(demoSubmit);
    showToast("Действие выполнено в демо-режиме");
    return;
  }

  const exportButton = event.target.closest('[data-action="export"]');
  if (exportButton) {
    showToast("Демо-отчет подготовлен к экспорту");
    return;
  }

  const menuLink = event.target.closest(".admin-menu a");
  if (menuLink) {
    document.querySelectorAll(".admin-menu a").forEach((link) => link.classList.remove("active"));
    menuLink.classList.add("active");
    const hash = menuLink.getAttribute("href")?.replace("#", "");
    if (hash && tabByHash[hash]) {
      setActiveTab(tabByHash[hash]);
    }
  }
});

document.addEventListener("keydown", (event) => {
  if (event.key !== "Escape") return;
  document.querySelectorAll(".modal-backdrop:not([hidden])").forEach((modal) => {
    modal.hidden = true;
  });
  document.body.classList.remove("modal-open");
});

const revealItems = document.querySelectorAll(
  ".hero, .metrics article, .module-grid article, .panel, .tour-card, .live-feed article"
);

revealItems.forEach((item, index) => {
  item.classList.add("reveal");
  item.style.transitionDelay = `${Math.min(index * 35, 280)}ms`;
});

const revealObserver = new IntersectionObserver(
  (entries) => {
    entries.forEach((entry) => {
      if (!entry.isIntersecting) return;
      entry.target.classList.add("is-visible");
      revealObserver.unobserve(entry.target);
    });
  },
  { threshold: 0.12 }
);

revealItems.forEach((item) => revealObserver.observe(item));

document.querySelectorAll(".panel, .metrics article, .module-grid article, .live-strip div, .floating-live-card, .live-booking-card").forEach((card) => {
  card.addEventListener("pointermove", (event) => {
    const rect = card.getBoundingClientRect();
    const x = ((event.clientX - rect.left) / rect.width) * 100;
    const y = ((event.clientY - rect.top) / rect.height) * 100;
    card.style.setProperty("--mx", `${x}%`);
    card.style.setProperty("--my", `${y}%`);
  });
});

if (document.querySelector('[data-role-view="admin"]')) {
  setRole("admin");
}

const searchInput = document.querySelector("[data-search-input]");
const searchSuggestions = document.querySelector("[data-search-suggestions]");

function getPanelName(element) {
  return element.closest("[data-panel]")?.dataset.panel ?? "overview";
}

function getReadableText(element) {
  const parts = [...element.querySelectorAll("h2, h3, strong, span, small, p, td, b")]
    .map((node) => node.textContent.replace(/\s+/g, " ").trim())
    .filter(Boolean);

  return [...new Set(parts)].join(" · ");
}

function buildSearchIndex() {
  const entries = [];
  const pushEntry = (element, title, subtitle, tab) => {
    const cleanTitle = title?.replace(/\s+/g, " ").trim();
    if (!element || !cleanTitle) return;
    entries.push({
      element,
      title: cleanTitle,
      subtitle: subtitle?.replace(/\s+/g, " ").trim() || "Раздел админ-панели",
      tab: tab || getPanelName(element),
      haystack: `${cleanTitle} ${subtitle ?? ""}`.toLowerCase(),
    });
  };

  document.querySelectorAll(".metrics article").forEach((element) => {
    pushEntry(element, element.querySelector("span")?.textContent, getReadableText(element), getPanelName(element));
  });

  document.querySelectorAll(".admin-module-board article").forEach((element) => {
    pushEntry(element, element.querySelector("h2")?.textContent, getReadableText(element), getPanelName(element));
  });

  document.querySelectorAll("tbody tr").forEach((element) => {
    pushEntry(element, element.querySelector("strong")?.textContent, getReadableText(element), getPanelName(element));
  });

  document.querySelectorAll(".tour-card").forEach((element) => {
    pushEntry(element, element.querySelector("h3")?.textContent, getReadableText(element), getPanelName(element));
  });

  document.querySelectorAll(".supplier-list article, .task-list article, .campaigns article, .settings-cards article").forEach((element) => {
    pushEntry(element, element.querySelector("strong")?.textContent, getReadableText(element), getPanelName(element));
  });

  return entries;
}

const searchIndex = buildSearchIndex();

function highlightMatch(text, query) {
  const normalized = query.trim();
  if (!normalized) return text;
  const index = text.toLowerCase().indexOf(normalized.toLowerCase());
  if (index < 0) return text;
  return `${text.slice(0, index)}<mark>${text.slice(index, index + normalized.length)}</mark>${text.slice(index + normalized.length)}`;
}

function hideSearchSuggestions() {
  if (!searchSuggestions) return;
  searchSuggestions.hidden = true;
  searchSuggestions.innerHTML = "";
}

function focusSearchResult(result) {
  if (result.tab) {
    setActiveTab(result.tab);
  }

  window.setTimeout(() => {
    result.element.scrollIntoView({ behavior: "smooth", block: "center" });
    result.element.classList.remove("search-hit");
    void result.element.offsetWidth;
    result.element.classList.add("search-hit");
  }, 120);
}

function renderSearchSuggestions(query) {
  if (!searchSuggestions) return;
  const value = query.trim().toLowerCase();
  if (value.length < 2) {
    hideSearchSuggestions();
    return;
  }

  const results = searchIndex
    .filter((entry) => entry.haystack.includes(value))
    .slice(0, 7);

  searchSuggestions.innerHTML = "";
  searchSuggestions.hidden = false;

  if (!results.length) {
    const empty = document.createElement("div");
    empty.className = "search-empty";
    empty.textContent = "Ничего не найдено";
    searchSuggestions.append(empty);
    return;
  }

  results.forEach((result, index) => {
    const button = document.createElement("button");
    button.type = "button";
    button.classList.toggle("active", index === 0);
    button.innerHTML = `<strong>${highlightMatch(result.title, query)}</strong><small>${highlightMatch(result.subtitle, query)}</small>`;
    button.addEventListener("click", () => {
      hideSearchSuggestions();
      searchInput.value = result.title;
      focusSearchResult(result);
    });
    searchSuggestions.append(button);
  });
}

if (searchInput && searchSuggestions) {
  searchInput.addEventListener("input", () => renderSearchSuggestions(searchInput.value));
  searchInput.addEventListener("focus", () => renderSearchSuggestions(searchInput.value));
  searchInput.addEventListener("keydown", (event) => {
    const active = searchSuggestions.querySelector("button.active");
    if (event.key === "Enter") {
      event.preventDefault();
      active?.click();
      return;
    }

    if (!["ArrowDown", "ArrowUp"].includes(event.key)) return;
    event.preventDefault();
    const buttons = [...searchSuggestions.querySelectorAll("button")];
    if (!buttons.length) return;
    const currentIndex = Math.max(0, buttons.indexOf(active));
    const nextIndex = event.key === "ArrowDown"
      ? Math.min(buttons.length - 1, currentIndex + 1)
      : Math.max(0, currentIndex - 1);
    buttons.forEach((button, index) => button.classList.toggle("active", index === nextIndex));
  });
}

document.addEventListener("click", (event) => {
  if (!event.target.closest(".search")) {
    hideSearchSuggestions();
  }
});

const liveMessages = [
  "Новая заявка: Байкал на 4 туриста",
  "Агент открыл B2B прайс по Сочи",
  "Клиент запросил программу Камчатки",
  "Поставщик подтвердил квоту отеля",
  "Оплачен счет по туру Алтай Adventure",
];

setInterval(() => {
  document.querySelectorAll("[data-live-number]").forEach((node) => {
    const current = Number.parseInt(node.textContent.replace(/\D/g, ""), 10) || 20;
    node.textContent = String(current + Math.floor(Math.random() * 5) - 1);
  });

  const feed = document.querySelector("[data-live-feed]");
  if (!feed) return;
  const item = document.createElement("article");
  item.innerHTML = `<span></span><div><strong>${liveMessages[Math.floor(Math.random() * liveMessages.length)]}</strong><small>только что</small></div>`;
  feed.prepend(item);
  [...feed.children].slice(5).forEach((child) => child.remove());
}, 3500);
