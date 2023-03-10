import { describe, it, expect } from "vitest";

import { mount } from "@vue/test-utils";
import HomeContent from "../HomeContent.vue";

describe("HomeContent", () => {
  it("renders properly", () => {
    const wrapper = mount(HomeContent);
    expect(wrapper).toBeTruthy();
  });
});
